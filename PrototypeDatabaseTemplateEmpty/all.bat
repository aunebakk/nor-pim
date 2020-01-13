rem PrototypeDotNetCoreTemplateEmpty
dotnet new
dotnet restore  PrototypeDatabaseTemplateEmpty.csproj
dotnet build  PrototypeDatabaseTemplateEmpty.csproj
dotnet publish  PrototypeDatabaseTemplateEmpty.csproj
call publish
echo Thats it folks!
pause