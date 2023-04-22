aDir=$(dirname "$0")
cd $aDir
dotnet run --project ./build/Build.csproj -- "$@"
