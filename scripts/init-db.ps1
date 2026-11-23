[CmdletBinding()]
param()

$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $PSScriptRoot
$servidor = "(localdb)\MSSQLLocalDB"
$baseDatos = "Ci.Almaseg.Ferreteria.Final"
$scriptDatos = Join-Path $root "database\Ci.Almaseg.Ferreteria.Final_Datos.sql"
$migracion = Join-Path $root "database\migrations\001_hash_passwords.sql"

. (Join-Path $PSScriptRoot "common.ps1")

$sqlcmd = Find-SqlCmd
Start-LocalDb | Out-Null

$existe = (& $sqlcmd -S $servidor -E -h -1 -W -Q "SET NOCOUNT ON; SELECT ISNULL(DB_ID(N'$baseDatos'), 0);" | Out-String).Trim()

if ($existe -eq "0") {
    Write-Host "Creando la base de datos y cargando los datos de demostración..." -ForegroundColor Cyan
    & $sqlcmd -S $servidor -E -b -I -f 65001 -i $scriptDatos
    if ($LASTEXITCODE -ne 0) {
        throw "No fue posible crear la base de datos."
    }
}
else {
    Write-Host "La base de datos ya existe." -ForegroundColor Yellow
    $pendientes = (& $sqlcmd -S $servidor -E -d $baseDatos -h -1 -W -Q "SET NOCOUNT ON; SELECT COUNT(*) FROM tbl.usuario WHERE LEN(clave_hash) <> 64;" | Out-String).Trim()

    if ($pendientes -ne "0") {
        Write-Host "Aplicando migración de contraseñas..." -ForegroundColor Yellow
        & $sqlcmd -S $servidor -E -b -I -f 65001 -i $migracion
        if ($LASTEXITCODE -ne 0) {
            throw "No fue posible aplicar la migración de contraseñas."
        }
    }
    else {
        Write-Host "Las migraciones están al día." -ForegroundColor Green
    }
}

$resumen = (& $sqlcmd -S $servidor -E -d $baseDatos -h -1 -W -Q "SET NOCOUNT ON; SELECT CONCAT((SELECT COUNT(*) FROM tbl.producto), N' productos | ', (SELECT COUNT(*) FROM tbl.usuario), N' usuarios | ', (SELECT COUNT(*) FROM tbl.venta), N' ventas');" | Out-String).Trim()

Write-Host "Base de datos lista: $baseDatos" -ForegroundColor Green
Write-Host $resumen
