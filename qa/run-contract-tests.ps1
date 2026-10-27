# Exact-source, Windows-only exercise contract tests. No network or package restore.
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$root = (Resolve-Path -LiteralPath (Join-Path $PSScriptRoot '..')).Path
$frameworks = @(
    (Join-Path $env:WINDIR 'Microsoft.NET\Framework64\v4.0.30319\csc.exe'),
    (Join-Path $env:WINDIR 'Microsoft.NET\Framework\v4.0.30319\csc.exe')
)
$compiler = $frameworks | Where-Object { Test-Path -LiteralPath $_ -PathType Leaf } | Select-Object -First 1
if (-not $compiler) { throw 'QA_MYFIRSTCS_FRAMEWORK_CSC_NOT_AVAILABLE: no download allowed' }

$sources = @(
    'Exercise6\Square.cs',
    'Exercise6_2\Taxpayer.cs',
    'Exercise6_3\Job.cs',
    'fromLecture56\BankAccount.cs',
    'fromLecture57\Person.cs',
    'qa\ContractTests.cs'
) | ForEach-Object {
    $path = Join-Path $root $_
    if (-not (Test-Path -LiteralPath $path -PathType Leaf)) {
        throw ('QA_MYFIRSTCS_SOURCE_MISSING: ' + $_)
    }
    (Resolve-Path -LiteralPath $path).Path
}
$work = Join-Path ([System.IO.Path]::GetTempPath()) ('qa-myfirstcs-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $work -ErrorAction Stop | Out-Null
try {
    $exe = Join-Path $work 'ContractTests.exe'
    & $compiler '/nologo' '/target:exe' '/r:System.Core.dll' ("/out:$exe") @sources
    if ($LASTEXITCODE -ne 0 -or -not (Test-Path -LiteralPath $exe -PathType Leaf)) {
        throw 'QA_MYFIRSTCS_CSHARP_COMPILATION_FAILED'
    }
    & $exe
    if ($LASTEXITCODE -ne 0) { throw 'QA_MYFIRSTCS_CONTRACT_FAILED' }
} finally {
    Remove-Item -LiteralPath $work -Recurse -Force -ErrorAction SilentlyContinue
}
