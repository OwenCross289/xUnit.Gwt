cd $PSScriptRoot
dotnet run --project build/Build.csproj --Configuration="Release"
exit $LASTEXITCODE;