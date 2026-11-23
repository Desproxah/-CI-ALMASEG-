[CmdletBinding()]
param()

$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $PSScriptRoot
Set-Location $root

function Find-MSBuild {
    $command = Get-Command msbuild.exe -ErrorAction SilentlyContinue
    if ($command) {
        return $command.Source
    }

    $vswhere = Join-Path ${env:ProgramFiles(x86)} "Microsoft Visual Studio\Installer\vswhere.exe"
    if (Test-Path $vswhere) {
        $result = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -find "MSBuild\**\Bin\MSBuild.exe" |
            Select-Object -First 1
        if ($result -and (Test-Path $result)) {
            return $result
        }
    }

    $patterns = @(
        (Join-Path $env:ProgramFiles "Microsoft Visual Studio\*\*\MSBuild\Current\Bin\MSBuild.exe"),
        (Join-Path ${env:ProgramFiles(x86)} "Microsoft Visual Studio\*\*\MSBuild\Current\Bin\MSBuild.exe")
    )

    foreach ($pattern in $patterns) {
        $found = Get-ChildItem $pattern -ErrorAction SilentlyContinue | Select-Object -First 1
        if ($found) {
            return $found.FullName
        }
    }

    return $null
}

$msbuild = Find-MSBuild
if (-not $msbuild) {
    throw "No se encontró MSBuild. Instala Visual Studio con la carga de trabajo '.NET desktop development' o Visual Studio Build Tools."
}

Write-Host "Usando MSBuild: $msbuild" -ForegroundColor DarkGray
& $msbuild "CIAlmaseg\CIAlmaseg.csproj" /t:Rebuild /p:Configuration=Release /p:Platform=AnyCPU /v:minimal
if ($LASTEXITCODE -ne 0) {
    throw "La compilación falló."
}

$dist = Join-Path $root "dist\CIAlmaseg"
if (Test-Path $dist) {
    Remove-Item $dist -Recurse -Force
}
New-Item -ItemType Directory -Force -Path $dist | Out-Null
Copy-Item "CIAlmaseg\bin\Release\*" $dist -Recurse -Force

Write-Host "Aplicación compilada en: $dist" -ForegroundColor Green
Get-ChildItem $dist | Select-Object Name, Length
