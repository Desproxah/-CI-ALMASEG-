[CmdletBinding()]
param()

$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $PSScriptRoot
$exe = Join-Path $root "dist\CIAlmaseg\CIAlmaseg.exe"

if (-not (Test-Path $exe)) {
    throw "No existe el ejecutable. Ejecuta primero .\scripts\build-app.ps1 o .\scripts\start.ps1"
}

Write-Host "Abriendo CI Almaseg..." -ForegroundColor Cyan
Start-Process -FilePath $exe -WorkingDirectory (Split-Path -Parent $exe)
