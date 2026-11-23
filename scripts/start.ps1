[CmdletBinding()]
param(
    [switch]$SkipApp
)

$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $PSScriptRoot
Set-Location $root

Write-Host "CI Almaseg - inicio local" -ForegroundColor Cyan
& (Join-Path $PSScriptRoot "init-db.ps1")

$exe = Join-Path $root "dist\CIAlmaseg\CIAlmaseg.exe"
$necesitaCompilar = -not (Test-Path $exe)

if (-not $necesitaCompilar) {
    $fechaExe = (Get-Item $exe).LastWriteTime
    $fuentes = Get-ChildItem (Join-Path $root "CIAlmaseg") -Recurse -File |
        Where-Object {
            $_.FullName -notmatch '\\(bin|obj)\\' -and
            $_.Extension -in ".cs", ".config", ".csproj", ".resx", ".manifest"
        }

    $necesitaCompilar = [bool]($fuentes |
        Where-Object { $_.LastWriteTime -gt $fechaExe } |
        Select-Object -First 1)
}

if ($necesitaCompilar) {
    & (Join-Path $PSScriptRoot "build-app.ps1")
}
else {
    Write-Host "El ejecutable ya está actualizado." -ForegroundColor Green
}

if (-not $SkipApp) {
    & (Join-Path $PSScriptRoot "run-app.ps1")
}
