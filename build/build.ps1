# Basic msbuild script

# ---- Add the tool paths to our path
$runtimeDir = [System.Runtime.InteropServices.RuntimeEnvironment]::GetRuntimeDirectory()
$env:Path = $env:Path +";"+ $runtimeDir
Write-host "Added $runtimeDir to path"

# ---- Build solution using Release configuration
cd ../src/
msbuild NMockaroo.sln "/p:Configuration=Release"