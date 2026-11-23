@echo off
setlocal
cd /d "%~dp0"
powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0scripts\start.ps1"
if errorlevel 1 (
    echo.
    echo Ocurrio un error. Revisa el mensaje anterior.
    pause
)
