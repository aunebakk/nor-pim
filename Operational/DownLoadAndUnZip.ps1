# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 7/21/2020 9:49:07 AM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.AzureBase.DownLoadAndUnzip

        # web client
        [System.Net.WebClient] $wc = New-Object System.Net.WebClient
        [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]::Tls12;
        $wc = New-Object System.Net.WebClient

        if (Test-Path C:\SQL2XProjects\SolutionNorSolutionPim\Web\Scripts\garbage) {
            Remove-Item -Recurse C:\SQL2XProjects\SolutionNorSolutionPim\Web\Scripts\garbage
        }

        New-Item -ItemType:Directory C:\SQL2XProjects\SolutionNorSolutionPim\Web\Scripts\garbage

        $wc.DownloadFile(
                'https://github.com/twbs/bootstrap/releases/download/v3.4.1/bootstrap-3.4.1-dist.zip',
                (' ' + 'C:\SQL2XProjects\SolutionNorSolutionPim\Web\Scripts\garbage\bootstrap-3.4.1-dist.zip')
            )

        # extract zip
        Add-Type -Assembly System.IO.Compression.FileSystem
        [System.IO.Compression.ZipFile]::ExtractToDirectory(
            (' ' + 'C:\SQL2XProjects\SolutionNorSolutionPim\Web\Scripts\garbage\bootstrap-3.4.1-dist.zip'),
            (' ' + 'C:\SQL2XProjects\SolutionNorSolutionPim\Web\Scripts\garbage'),
            [System.Text.Encoding]::UTF8
            )

        if ($wc) { try { Remove-Variable -Name wc } catch {} }
        