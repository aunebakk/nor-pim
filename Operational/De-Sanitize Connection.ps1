# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 10/28/2020 10:24:45 PM
# From Machine: DESKTOP-9A2DH39
# Template: SQL2XExtensionV3.SQL2XExtensionCreatorNorSolution.Content_SanitizeConnectionUndo

param(
    [string]$gitHubUserTiney = '',

    [string]$emailLog = '',
    [string]$emailPersonalFirst = '',
    [string]$emailPersonalSecond = '',
    [string]$emailTiney = '',

    [string]$developerName = '',

    [string]$somePassword = '',
    [string]$passwordPersonalStyle = '',
    [string]$passwordPersonalStyleLargeEnding = '',
    [string]$passwordPersonalStyleLargeEndingTwo = '',

    [string]$azureUserName = '',
    [string]$azureWebAppProfileUserPassword = '',
    [string]$connectionStringAzureTable = '',

    [string]$azureSQLServerName = '',
    [string]$azureSQLServerPassword = '',
    [string]$azureSQLUserName = '',
    [string]$connectionStringSQLServer = '',

    [string]$azureClientId = '',
    [string]$azureClientSecret = '',
    [string]$azureClientTenantId = '',
    [string]$azureClientSubscriptionId = ''
)

[string] $startFolder = $pwd

# get parent path of this script
[string] $path = Split-Path $MyInvocation.MyCommand.Path
[string] $parent = Split-Path $path

[string] $sql2xParent = 'C:\\SQL2XProjects\\SolutionNorSolutionPim'

Set-Location $parent

# CSharp files
$match = '*.cs' #, '*.cshtml' , '*.cs', '*.svc', '*.ps1' # , '*.json'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # validate file ( some .cs build files are 0 length )
    if ($fileContent.Length -eq 0) {
        # Write-Host $file.fullname
        continue
    }

    # replace ado data sources ( not using REGEX )
    if ($PSBoundParameters.ContainsKey('connectionStringSQLServer')) {
        [string] $find = 'Data Source=(localdb)\MSSQLLocalDB;";'
        [string] $replace = $connectionStringSQLServer + '";'
        $fileContent = $fileContent | ForEach-Object { $_.Replace($find, $replace) }
    }

    # replace azure storage data sources
    if ($PSBoundParameters.ContainsKey('connectionStringAzureTable')) {
        [string] $find = 'DefaultEndpointsProtocol.+'
        [string] $replace = $connectionStringAzureTable + '";'
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# PowerShell files
$match = '*.ps1'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {


    # skip this script
    if ($file.name -eq 'Sanitize Connection.ps1') {
        continue
    }

    if ($file.name -eq 'De-Sanitize Connection.ps1') {
        continue
    }

    if ($file.name -eq 'De-Sanitize Connection to SQL2X.ps1') {
        continue
    }

    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace azure storage data sources
    if ($PSBoundParameters.ContainsKey('connectionStringAzureTable')) {
        [string] $find = 'DefaultEndpointsProtocol.+'
        [string] $replace = $connectionStringAzureTable
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # replace sql2x path with git clone path
    $fileContent = $fileContent | ForEach-Object { $_ -Replace $sql2xParent, $parent } 

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# json files
$match = '*.json'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace ado data sources
    if ($PSBoundParameters.ContainsKey('connectionStringSQLServer')) {
        [string] $find = 'Data Source.+' 
        [string] $replace = $connectionStringSQLServer.Replace('\', '\\') + '",'
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # replace azure storage data sources
    if ($PSBoundParameters.ContainsKey('connectionStringAzureTable')) {
        [string] $find = 'DefaultEndpointsProtocol.+'
        [string] $replace = $connectionStringAzureTable + '",'
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # deploylink ( has no comma after parameter )
    if ($PSBoundParameters.ContainsKey('connectionStringSQLServer')) {
        [string] $find = '"deploylink": "Data Source.+' 
        [string] $replace = '"deploylink": "' + $connectionStringSQLServer.Replace('\', '\\') + '"'
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # you
    if ($PSBoundParameters.ContainsKey('developerName')) {
        [string] $find = 'developerName'
        [string] $replace = $developerName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # password
    if ($PSBoundParameters.ContainsKey('passwordPersonalStyleLargeEnding')) {
        [string] $find = 'passwordPersonalStyleLargeEnding'
        [string] $replace = $passwordPersonalStyleLargeEnding
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# config files
$match = '*.config'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace ado data sources ( 'Data Source="' +  )
    if ($PSBoundParameters.ContainsKey('connectionStringSQLServer')) {
        [string] $find = 'Data Source.+' 
        [string] $replace = $connectionStringSQLServer + '"/>'
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # replace azure storage data sources
    if ($PSBoundParameters.ContainsKey('connectionStringAzureTable')) {
        [string] $find = 'DefaultEndpointsProtocol.+'
        [string] $replace = 'DefaultEndpointsProtocol="' + $connectionStringAzureTable + '"/>' 
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # replace sql server connection strings
    if ($PSBoundParameters.ContainsKey('connectionStringSQLServer')) {
        [string] $find = 'connectionString=.+'
        [string] $replace = 'connectionString="' + $connectionStringSQLServer + '"/>'
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# csharp files
$match = '*.cs'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace client secrets
    if ($PSBoundParameters.ContainsKey('azureClientId')) {
        [string] $find = 'string clientId = .+(?-i)' 
        [string] $replace = 'string clientId = ' + ('"' + $azureClientId + '";')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    if ($PSBoundParameters.ContainsKey('azureClientSecret')) {
        [string] $find = 'string secret = .+' 
        [string] $replace = 'string secret = ' + ('"' + $azureClientSecret + '";')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    if ($PSBoundParameters.ContainsKey('azureClientTenantId')) {
        [string] $find = 'string tenantId = .+' 
        [string] $replace = 'string tenantId = ' + ('"' + $azureClientTenantId + '";')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    if ($PSBoundParameters.ContainsKey('azureClientSubscriptionId')) {
        [string] $find = 'string subscriptionId = .+' 
        [string] $replace = 'string subscriptionId = ' + ('"' + $azureClientSubscriptionId + '";')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # replace client secrets in javascript cshtml files?
    if ($PSBoundParameters.ContainsKey('azureClientId')) {
        [string] $find = 'var clientId = .+' 
        [string] $replace = 'var clientId = ' + ('"' + $azureClientId + '"')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    if ($PSBoundParameters.ContainsKey('azureClientSecret')) {
        [string] $find = 'var secret = .+' 
        [string] $replace = 'var secret = ' + ('"' + $azureClientSecret + '"')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    if ($PSBoundParameters.ContainsKey('azureClientTenantId')) {
        [string] $find = 'var tenantId = .+' 
        [string] $replace = 'var tenantId = ' + ('"' + $azureClientTenantId + '"')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    if ($PSBoundParameters.ContainsKey('azureClientSubscriptionId')) {
        [string] $find = 'var subscriptionId = .+' 
        [string] $replace = 'var subscriptionId = ' + ('"' + $azureClientSubscriptionId + '"')
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # server name
    if ($PSBoundParameters.ContainsKey('azureSQLServerName')) {
        [string] $find = 'azureSQLServerName'
        [string] $replace = $azureSQLServerName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# batch
$match = '*.bat'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {
    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace password
    if ($PSBoundParameters.ContainsKey('somePassword')) {
        [string] $find = "Password="
        [string] $replace = 'Password=' + ("'" + $somePassword + "'")

        if ($fileContent.indexof($find) -ge 0 ) {

            # position of password
            # start of password value
            # password starts after tick        
            if ($fileContent.substring( `
                      $fileContent.indexof($find)  `
                    + $find.length `
                    + 1 `
                    ).indexof("'") -ge 0) {

                # start of password including tick
                # start looking after tick
                # end of password
                # remainder after password and tick            
                $fileContent = ( `
                      $fileContent.substring( 0, `
                                              $fileContent.indexof($find) `
                                              ) `
                    + $replace `
                    + $fileContent.substring( `
                        $fileContent.indexof($find) + $find.length `
                            + 1 `
                            + $fileContent.substring( `
                                    $fileContent.indexof($find) + $find.length `
                                + 1 `
                                ).indexof("'") `
                                + 1 `
                    )
                )
            }
        }
    }

    # replace sql2x path with git clone path
    $fileContent = $fileContent | ForEach-Object { $_ -Replace $sql2xParent, $parent } 

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# PowerShell files
$match = '*.ps1'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {


    # skip this script
    if ($file.name -eq 'Sanitize Connection.ps1') {
        continue
    }

    if ($file.name -eq 'De-Sanitize Connection.ps1') {
        continue
    }

    if ($file.name -eq 'De-Sanitize Connection to SQL2X.ps1') {
        continue
    }

    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace email address's
    if ($PSBoundParameters.ContainsKey('emailLog')) {
        [string] $find = 'emailLog'
        [string] $replace = $emailLog
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('emailPersonalFirst')) {
        [string] $find = 'emailPersonal@first.com'
        [string] $replace = $emailPersonalFirst
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('emailPersonalSecond')) {
        [string] $find = 'emailPersonal@Second.com'
        [string] $replace = $emailPersonalSecond
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('emailTiney')) {
        [string] $find = 'email@Tiney.com'
        [string] $replace = $emailTiney
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('azureUserName')) {
        [string] $find = 'azureUserName'
        [string] $replace = $azureUserName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('azureSQLUserName')) {
        [string] $find = 'azureSQLUserName'
        [string] $replace = $azureSQLUserName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('gitHubUserTiney')) {
        [string] $find = 'gitHubUserTiney'
        [string] $replace = $gitHubUserTiney
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('developerName')) {
        [string] $find = 'developerName'
        [string] $replace = $developerName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # replace password's
    if ($PSBoundParameters.ContainsKey('passwordPersonalStyleLargeEndingTwo')) {
        [string] $find = 'passwordPersonalStyleLargeEndingTwo'
        [string] $replace = $passwordPersonalStyleLargeEndingTwo
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('passwordPersonalStyle')) {
        [string] $find = 'passwordPersonalStyle'
        [string] $replace = $passwordPersonalStyle
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('XXX')) {
        [string] $find = 'developerName'
        [string] $replace = $developerName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('azureSQLServerPassword')) {
        [string] $find = 'azureSQLServerPassword'
        [string] $replace = $azureSQLServerPassword
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # azure sql server
    if ($PSBoundParameters.ContainsKey('azureSQLServerName')) {
        [string] $find = 'azureSQLServerName'
        [string] $replace = $azureSQLServerName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # clientId, secret, tenantId and subscriptionId
    if ($PSBoundParameters.ContainsKey('azureClientId')) {
        [string] $find = 'azureClientId'
        [string] $replace = $azureClientId
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('azureSecretId')) {
        [string] $find = 'azureClientSecret'
        [string] $replace = $azureSecretId
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('azureClientTenantId')) {
        [string] $find = 'azureClientTenantId'
        [string] $replace = $azureClientTenantId
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    if ($PSBoundParameters.ContainsKey('azureSubscriptionId')) {
        [string] $find = 'azureClientSubscriptionId'
        [string] $replace = $azureSubscriptionId
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# azure publish settings
$match = '*.publishSettings'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {

    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace userPWD 
    if ($PSBoundParameters.ContainsKey('azureWebAppProfileUserPassword')) {
        [string] $find = 'azureWebAppProfileUserPassword'
        [string] $replace = $azureWebAppProfileUserPassword

        [int] $findPos = $fileContent.IndexOf($find)

        while ($findPos -gt 0) {
            # find node
            [string] $remainder = $fileContent.SubString($findPos)

            # get next quotes
            $remainder = $remainder.SubString($remainder.IndexOf('"') + 1)

            # and the next quotes, should be the end of the node
            $remainder = $remainder.SubString($remainder.IndexOf('"') + 1)

            # construct replacement node
            [string] $newNode = $find + '"' + $replace + '"'
            $fileContent = $fileContent.SubString(0, $findPos) + $newNode + $remainder

            # next node
            $findPos = $fileContent.IndexOf($find, $findPos + 1)
        }
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

# visual studio projects
$match = '*proj.*'
foreach ($file in Get-ChildItem -recurse -include $match | Where-Object { Test-Path $_.fullname -PathType leaf} ) {

    [string] $fileContent = Get-Content $file -Raw
    [string] $fileContentOriginal = $fileContent

    # replace sql server name
    if ($PSBoundParameters.ContainsKey('XXX')) {
        [string] $find = 'azureSQLServerName'
        [string] $replace = $azureSQLServerName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # replace sql server password
    if ($PSBoundParameters.ContainsKey('azureSQLServerPassword')) {
        [string] $find = 'azureSQLServerPassword'
        [string] $replace = $azureSQLServerPassword
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # replace sql server user
    if ($PSBoundParameters.ContainsKey('azureSQLUserName')) {
        [string] $find = 'azureSQLUserName'
        [string] $replace = $azureSQLUserName
        $fileContent = $fileContent | ForEach-Object { $_ -Replace $find, $replace } 
    }

    # show filename if changed
    if ($fileContentOriginal -ne $fileContent) {
        'de-sanitizing ' + $match + ' : ' + $file
        $fileContent | Set-Content ( $file )
    }
}

Set-Location $startFolder
Write-Host 'Done'
