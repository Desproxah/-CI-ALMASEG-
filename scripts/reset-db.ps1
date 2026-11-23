[CmdletBinding()]
param(
    [switch]$Force
)

$ErrorActionPreference = "Stop"
$servidor = "(localdb)\MSSQLLocalDB"
$baseDatos = "Ci.Almaseg.Ferreteria.Final"

. (Join-Path $PSScriptRoot "common.ps1")

if (-not $Force) {
    $respuesta = Read-Host "Esto eliminará la base de datos '$baseDatos' y volverá a cargar los datos de demostración. Escribe SI para continuar"
    if ($respuesta -ne "SI") {
        Write-Host "Operación cancelada." -ForegroundColor Yellow
        return
    }
}

$sqlcmd = Find-SqlCmd
Start-LocalDb | Out-Null

Write-Host "Eliminando la base de datos..." -ForegroundColor Yellow
$consulta = "IF DB_ID(N'$baseDatos') IS NOT NULL BEGIN ALTER DATABASE [$baseDatos] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE [$baseDatos]; END;"

& $sqlcmd -S $servidor -E -b -Q $consulta
if ($LASTEXITCODE -ne 0) {
    throw "No fue posible eliminar la base de datos."
}

& (Join-Path $PSScriptRoot "init-db.ps1")
