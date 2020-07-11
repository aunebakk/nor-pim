rem PrototypeDotNetCoreTemplateEmpty
dotnet new
dotnet restore  Database.csproj
dotnet build  Database.csproj
dotnet publish  Database.csproj
call publish
echo Thats it folks!
pause