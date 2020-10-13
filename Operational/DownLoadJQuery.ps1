# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 10/13/2020 2:17:19 PM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.AzureBase.DownLoad
try {
            # web client
            [System.Net.WebClient] $wc = New-Object System.Net.WebClient
            [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]::Tls12;
            $wc = New-Object System.Net.WebClient

            $wc.DownloadFile(
                    'https://code.jquery.com/jquery-3.2.1.js',
                    (' ' + 'C:\SQL2XProjects\SolutionNorSolutionPim\Web\Scripts\jquery-3.2.1.js')
                )

        } catch [Exception] {
        } finally {
            if ($wc) { try { Remove-Variable -Name wc } catch {} }
        }
        