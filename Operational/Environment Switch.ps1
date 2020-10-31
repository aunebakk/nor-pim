# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 10/31/2020 7:21:31 AM
# From Machine: DESKTOP-9A2DH39
# Template: SQL2XExtensionV3.SQL2XExtensionCreatorNorSolution.Content_EnvironmentSwitch
param (
    [Parameter(Mandatory=$true)]
    [switch]$toRemote
)
[string] $startFolder = $pwd

# get parent path of this script
[string] $path = Split-Path $MyInvocation.MyCommand.Path
[string] $parent = Split-Path $path

Set-Location $parent

[string[]] $match = 'connection.config','Web.config','ConnectionString.cs'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.FullName -PathType leaf} ) {
    # exclude this script
    if ($file.FullName -eq $MyInvocation.MyCommand.Path) {
        continue
    }

    # get file content
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( exclude files of 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.FullName
        continue
    }

    # replace
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;', 'Data Source=sqlServerName.database.windows.net;Persist Security Info=True;User ID=sqlServerUserName;Password=sqlServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('Data Source=sqlServerName.database.windows.net;Persist Security Info=True;User ID=sqlServerUserName;Password=sqlServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;', 'Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;') }
    }

    # save file and show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

[string[]] $match = '*.config','*.cs','*.ts','*.cshtml'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.FullName -PathType leaf} ) {
    # exclude this script
    if ($file.FullName -eq $MyInvocation.MyCommand.Path) {
        continue
    }

    # get file content
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( exclude files of 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.FullName
        continue
    }

    # replace
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:5000', 'NorSolutionPimCore.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPimCore.azurewebsites.net', 'localhost:5000') }
    }

    # save file and show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

[string[]] $match = '*.config','*.cs','*.ts','*.cshtml'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.FullName -PathType leaf} ) {
    # exclude this script
    if ($file.FullName -eq $MyInvocation.MyCommand.Path) {
        continue
    }

    # get file content
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( exclude files of 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.FullName
        continue
    }

    # replace
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:64804', 'NorSolutionPimBusiness.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPimBusiness.azurewebsites.net', 'localhost:64804') }
    }

    # save file and show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

[string[]] $match = '*.config','*.cs','*.ts','*.cshtml'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.FullName -PathType leaf} ) {
    # exclude this script
    if ($file.FullName -eq $MyInvocation.MyCommand.Path) {
        continue
    }

    # get file content
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( exclude files of 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.FullName
        continue
    }

    # replace
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:44341', 'NorSolutionPim.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPim.azurewebsites.net', 'localhost:44341') }
    }

    # save file and show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

Set-Location $startFolder
