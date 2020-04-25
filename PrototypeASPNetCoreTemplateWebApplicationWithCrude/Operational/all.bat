rem SQL2X Generated code based on a SQL Server Schema
rem SQL2X Version: 1.0
rem http://sql2x.org/
rem Generated Date: 4/25/2020 9:44:59 AM
rem Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_allDOTBat
rem Create new .net core 2.1 project
cd ..
rem Fix packages
dotnet new razorrem Fix packages
dotnet restore  PrototypeASPNetCoreTemplateWebApplicationWithCrude.csproj
rem Build
dotnet build  PrototypeASPNetCoreTemplateWebApplicationWithCrude.csproj
rem Run
dotnet publish  PrototypeASPNetCoreTemplateWebApplicationWithCrude.csproj
cd Operational
call publish
echo Done
pause
