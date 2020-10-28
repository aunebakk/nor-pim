# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 10/28/2020 8:20:51 PM
# From Machine: DESKTOP-9A2DH39
# Template: SQL2XExtensionV3.SQL2XExtensionCreatorNorSolution.Content_EnvironmentSwitch

[string] $startFolder = $pwd

# get parent path of this script
[string] $path = Split-Path $MyInvocation.MyCommand.Path
[string] $parent = Split-Path $path

Set-Location $parent

$match = 'ConnectionString.cs'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;', 'ConnectionString = @"Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('ConnectionString = @"Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;', 'ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = 'connection.config;Web.config'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;', 'Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;', 'Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = '*.*;*.*'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:5000', 'NorSolutionPimCore.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPimCore.azurewebsites.net', 'localhost:5000') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = '*.*;*.*'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:64804', 'NorSolutionPimBusiness.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPimBusiness.azurewebsites.net', 'localhost:64804') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = '*.*;*.*'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:44341', 'NorSolutionPim.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPim.azurewebsites.net', 'localhost:44341') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = 'ConnectionString.cs'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;', 'ConnectionString = @"Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('ConnectionString = @"Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;', 'ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = 'connection.config;Web.config'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;', 'Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('Data Source=azureSQLServerName.database.windows.net;Persist Security Info=True;User ID=azureSQLUserName;Password=azureSQLServerPassword;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=120;Initial Catalog=NorSolutionPim;', 'Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=NorSolutionPim;') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = '*.*;*.*'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:5000', 'NorSolutionPimCore.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPimCore.azurewebsites.net', 'localhost:5000') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = '*.*;*.*'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:64804', 'NorSolutionPimBusiness.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPimBusiness.azurewebsites.net', 'localhost:64804') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

$match = '*.*;*.*'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ( not using REGEX )
    if ($toRemote) {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('localhost:44341', 'NorSolutionPim.azurewebsites.net') }
    } else {
        $fileContent = $fileContent | ForEach-Object { $_.Replace('NorSolutionPim.azurewebsites.net', 'localhost:44341') }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

Set-Location $startFolder
