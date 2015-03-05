$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\src\NMockaroo\bin\Release\NMockaroo.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\tools\nuget\NMockaroo.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\build\NMockaroo.compiled.nuspec

& $root\tools\nuget\NuGet.exe pack $root\build\NMockaroo.compiled.nuspec