cd $PSScriptRoot
dotnet run --project build/Build.csproj --Configuration="Debug"
exit $LASTEXITCODE;