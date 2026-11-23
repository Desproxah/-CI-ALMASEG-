[CmdletBinding()]
param()

$ErrorActionPreference = "Stop"

. (Join-Path $PSScriptRoot "common.ps1")

$localdb = Find-SqlLocalDb
Write-Host "Deteniendo LocalDB (los datos se conservan)..." -ForegroundColor Yellow
& $localdb stop MSSQLLocalDB
