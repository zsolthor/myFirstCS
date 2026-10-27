# Offline Windows exercise contracts

Run: `powershell.exe -NoProfile -NonInteractive -ExecutionPolicy Bypass -File qa/run-contract-tests.ps1`

This compiles five **unchanged** production exercise classes with the built-in
.NET Framework C# compiler into a temporary folder. It checks actual behavior
(area, taxpayer thresholds, job fee recalculation, bank account addition, and
person state). No NuGet, internet, restore, external service, GUI, or installation.

If `csc.exe` is not already installed under the Windows .NET Framework folders,
the script **fails** with a clear diagnostic; it never installs dependencies.
Only these selected exercises are covered, not the entire solution.

Status: Draft only; a passing run on the named Windows QA Runner at the exact PR
HEAD is still required before this can be advertised as a tested profile.
