# Funciones compartidas por los scripts de CI Almaseg.

function Find-SqlLocalDb {
    $comando = Get-Command sqllocaldb.exe -ErrorAction SilentlyContinue
    if ($comando) {
        return $comando.Source
    }

    $encontrado = Get-ChildItem (Join-Path $env:ProgramFiles "Microsoft SQL Server\*\Tools\Binn\SqlLocalDB.exe") -ErrorAction SilentlyContinue |
        Sort-Object FullName -Descending |
        Select-Object -First 1

    if ($encontrado) {
        return $encontrado.FullName
    }

    throw "No se encontró SQL Server LocalDB. Instálalo y vuelve a intentar."
}

function Find-SqlCmd {
    $comando = Get-Command sqlcmd.exe -ErrorAction SilentlyContinue
    if ($comando) {
        return $comando.Source
    }

    $patrones = @(
        (Join-Path ${env:ProgramFiles(x86)} "Microsoft SQL Server\Client SDK\ODBC\*\Tools\Binn\SQLCMD.EXE"),
        (Join-Path $env:ProgramFiles "Microsoft SQL Server\Client SDK\ODBC\*\Tools\Binn\SQLCMD.EXE")
    )

    foreach ($patron in $patrones) {
        $encontrado = Get-ChildItem $patron -ErrorAction SilentlyContinue |
            Sort-Object FullName -Descending |
            Select-Object -First 1
        if ($encontrado) {
            return $encontrado.FullName
        }
    }

    throw "No se encontró sqlcmd.exe. Instala las herramientas de línea de comandos de SQL Server."
}

function Start-LocalDb {
    $localdb = Find-SqlLocalDb
    $instancias = & $localdb info

    if ($instancias -notcontains "MSSQLLocalDB") {
        Write-Host "Creando la instancia LocalDB MSSQLLocalDB..." -ForegroundColor Yellow
        & $localdb create MSSQLLocalDB | Out-Null
    }

    & $localdb start MSSQLLocalDB 2>$null | Out-Null
    return $localdb
}
