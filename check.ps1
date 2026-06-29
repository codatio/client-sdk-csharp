#requires -Version 7
[CmdletBinding()]
param(
    [string]$Target = ''
)

$ErrorActionPreference = 'Stop'
$repoRoot = $PSScriptRoot

$testProjects = Get-ChildItem -Path $repoRoot -Recurse -Filter '*.csproj' |
    Where-Object { $_.FullName -match '[\\/]tests[\\/]' }

if ($Target) {
    $prefix = (Join-Path $repoRoot $Target)
    $testProjects = $testProjects | Where-Object { $_.FullName.StartsWith($prefix, [System.StringComparison]::OrdinalIgnoreCase) }
}

if (-not $testProjects) {
    Write-Error "No test projects found$(if ($Target) { " for target '$Target'" })."
    exit 1
}

$failed = @()

foreach ($proj in $testProjects) {
    Write-Host "==> $($proj.FullName)" -ForegroundColor Cyan

    dotnet build $proj.FullName -c Release --nologo
    if ($LASTEXITCODE -ne 0) { $failed += "build: $($proj.Name)"; continue }

    $env:DiffEngine_Disabled = 'true'
    $env:CI = 'true'
    dotnet test $proj.FullName -c Release --no-build `
        --logger 'trx;LogFileName=results.trx' `
        --results-directory (Join-Path $proj.Directory.FullName 'test-results')
    if ($LASTEXITCODE -ne 0) { $failed += "test: $($proj.Name)" }
}

if ($failed) {
    Write-Host "FAILED: $($failed -join ', ')" -ForegroundColor Red
    exit 1
}

Write-Host 'OK' -ForegroundColor Green
