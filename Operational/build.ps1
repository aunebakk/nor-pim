# & '.\build.ps1' -doEcho -doDevelopment -comment test
param (
    [string]$scriptName = 'restore sql2x and solutions',
    [string]$scriptStyle = 'original', # original / task
    [string]$scriptStatus = 'status ( todos, learn, learned )',
    [string]$scriptDocumentation = 'links urls, books, people, inspiration',

    [DateTime]$dateTimeStart = [System.DateTime]::UtcNow,
    [DateTime]$dateTimeStop = [System.DateTime]::UtcNow,
    [DateTime]$createdDateTime = '2018.03.14',
    [DateTime]$updateDateTime = '2018.05.09',

    [switch]$doDevelopment = $false,
    [switch]$doTest = $false,
    [switch]$doStep = $false,
    [switch]$doEcho = $true,

    [string]$zenCopyPackagesFrom = "SolutionNorSolutionPim",

    [switch]$rethrow = $false,
    [string]$comment = 'no comment',
    [switch]$sendMail = $false,
    [switch]$returnHtml = $false,

    [switch]$uninstall = $false
)
#endregion
##################################################################################################################
$taskName = 'locals'
#region
##################################################################################################################
[string] $taskLine = ''
[string] $answer = ''
[bool] $mailAnyway = $false
[string] $htmlLog = ''

[string] $sql2x = 'C:\SQL2XProjects'
#endregion
##################################################################################################################
$taskName = 'set startup location'
#region
##################################################################################################################
try {
    [string] $startupDirectory = ''
    if ($doDevelopment) { 
        [string] $startupDirectory = 'C:\SQL2XProjects' + '\' + 'sql2x' + '\' + 'Scripts'
    } elseif ($doTest) {
        [string] $startupDirectory = $home + '\' + 'sql2x' + '\' + 'Scripts'   
    }
    if ($startupDirectory -ne '') { 
        Set-Location $startupDirectory -ErrorAction:Stop
    }
} catch [Exception] {
    if ($rethrow) {
        Write-Host ($taskName + ' ' + 'Exception; ' + $_.Exception.Message)
        throw [Exception] ('Failed to; ' + $taskName)
    } else {
        $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + ('Exception:' + ' ' + $taskName + ' ' + '[' +  $_.Exception.Message + ']' + ' ' + 'Line:[' + $_.InvocationInfo.ScriptLineNumber + ']')
        $htmlLog = $htmlLog + $taskLine + '<br>'
        if ($doEcho) { Write-Host ( $taskLine ) -ForegroundColor Red }
        $doDevelopment = $false; $doTest = $true
    }
}
#endregion
##################################################################################################################
$taskName = 'start script:'
#region
##################################################################################################################
$taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + $taskName `
        + ' ' + $MyInvocation.MyCommand.Name `
        + ' ' + $MyInvocation.MyCommand.Arguments
$htmlLog = $htmlLog + $taskLine + '<br>'
if ($doEcho) { Write-Host $taskLine }

if (-not (([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).
        IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator))) { 
    $taskLine = ([System.DateTime]::UtcNow.ToString() + ' ' + 'pwd:' + ' ' + $pwd + ' ' + 'Not Admin')
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doEcho) { Write-Host $taskLine }
} else {
    $taskLine = ([System.DateTime]::UtcNow.ToString() + ' ' + 'pwd:' + ' ' + $pwd + ' ' + 'Admin')
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doEcho) { Write-Host $taskLine }
}

$taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'doDevelopment;' + '[' + $doDevelopment + ']' + ' ' + 'doTest;' + '[' + $doTest + ']' + ' ' + 'doStep;' + '[' + $doStep + ']' + ' ' + 'doEcho;' + '[' + $doEcho + ']' + ' ' + 'rethrow;' + '[' + $rethrow + ']'
$htmlLog = $htmlLog + $taskLine + '<br>'
if ($doEcho) { Write-Host $taskLine }

# check comment
if ([string]::IsNullOrWhiteSpace($comment)) {
    [string] $comment = Read-Host -Prompt ([System.DateTime]::UtcNow.ToString() + ' ' + 'Comment')
    if ([string]::IsNullOrWhiteSpace($comment)) { throw [Exception] "Need a comment" }
}
$taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'comment:' + ' ' + $comment
$htmlLog = $htmlLog + $taskLine + '<br>'
if ($doEcho) { Write-Host $taskLine }
#endregion
##################################################################################################################
$taskName = 'clean solution'
#region
##################################################################################################################
try {
    [string] $vs2017Build = 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild.exe'
    [System.Diagnostics.ProcessStartInfo] $psi
    [System.Diagnostics.Process] $process
    [string] $line = ''
    
    # log
    $answer = 'yes'
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'start:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doStep) { $answer = Read-Host -Prompt ( $taskLine ) }
    elseif ($doEcho) { Write-Host ( $taskLine ) }

    if ($answer -ne 'no' -and ($doDevelopment -or $doTest)) { 
        $psi = New-object System.Diagnostics.ProcessStartInfo 
        $psi.CreateNoWindow = $true 
        $psi.WorkingDirectory = $sql2x + '\' + 'SolutionNorSolutionPim'
        $psi.UseShellExecute = $false 
        $psi.RedirectStandardOutput = $true 
        $psi.RedirectStandardError = $true 
        $psi.FileName = $vs2017Build
        $psi.Arguments = @($sql2x + '\' + 'SolutionNorSolutionPim' + '\' + 'SolutionNorSolutionPim' + '.sln' + ' /target:clean') 

        $process = New-Object System.Diagnostics.Process 
        $process.StartInfo = $psi 
        [void]$process.Start()
        do {
            # read
            [string] $line = $process.StandardOutput.ReadLine()
            Write-Host $line

            # log
            $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + $line
            $htmlLog = $htmlLog + $taskLine + '<br>'
            if ($doEcho) { Write-Host ( $taskLine ) }
        } while (!$process.HasExited)        
    }

    # log
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'end:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doEcho) { Write-Host ( $taskLine ) }
} catch [Exception] {
    if ($rethrow) {
        Write-Host ($taskName + ' ' + 'Exception; ' + $_.Exception.Message)
        throw [Exception] ('Failed to; ' + $taskName)
    } else {
        $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + ('Exception:' + ' ' + $taskName + ' ' + '[' +  $_.Exception.Message + ']' + ' ' + 'Line:[' + $_.InvocationInfo.ScriptLineNumber + ']')
        $htmlLog = $htmlLog + $taskLine + '<br>'
        if ($doEcho) { Write-Host ( $taskLine ) -ForegroundColor Red }
    }
} finally {
    if ($line) { try { Remove-Variable -Name line } catch {}}
    if ($process) { try { Remove-Variable -Name process } catch {}}
    if ($psi) { try { Remove-Variable -Name psi } catch {}}
    if ($vs2017Build) { try { Remove-Variable -Name vs2017Build } catch {} }
}
#endregion
##################################################################################################################
$taskName = 'restore packages for solution'
#region
##################################################################################################################
try {
    [string] $vs2017Build = 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild.exe'
    [System.Diagnostics.ProcessStartInfo] $psi
    [System.Diagnostics.Process] $process
    [string] $line = ''
    
    # log
    $answer = 'yes'
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'start:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doStep) { $answer = Read-Host -Prompt ( $taskLine ) }
    elseif ($doEcho) { Write-Host ( $taskLine ) }

    if ($answer -ne 'no' -and ($doDevelopment -or $doTest)) { 

        # first get local packages, if existing
        Copy-Item `
            -Recurse `
            -Force `
            -Path ($sql2x + "\" + "packages") `
            -Destination ($sql2x + "\" + $zenCopyPackagesFrom + "\" + "packages") 

        $psi = New-object System.Diagnostics.ProcessStartInfo 
        $psi.CreateNoWindow = $true 
        $psi.WorkingDirectory = $sql2x + '\' + 'SolutionNorSolutionPim'
        $psi.UseShellExecute = $false 
        $psi.RedirectStandardOutput = $true 
        $psi.RedirectStandardError = $true 
        $psi.FileName = $vs2017Build
        $psi.Arguments = @($sql2x + '\' + 'SolutionNorSolutionPim' + '\' + 'SolutionNorSolutionPim' + '.sln' + ' /target:restore') 
        
        $process = New-Object System.Diagnostics.Process 
        $process.StartInfo = $psi 
        [void]$process.Start()
        do {
            # read
            [string] $line = $process.StandardOutput.ReadLine()
            Write-Host $line

            # log
            $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + $line
            $htmlLog = $htmlLog + $taskLine + '<br>'
            if ($doEcho) { Write-Host ( $taskLine ) }
        } while (!$process.HasExited)        
    }

    # log
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'end:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doEcho) { Write-Host ( $taskLine ) }
} catch [Exception] {
    if ($rethrow) {
        Write-Host ($taskName + ' ' + 'Exception; ' + $_.Exception.Message)
        throw [Exception] ('Failed to; ' + $taskName)
    } else {
        $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + ('Exception:' + ' ' + $taskName + ' ' + '[' +  $_.Exception.Message + ']' + ' ' + 'Line:[' + $_.InvocationInfo.ScriptLineNumber + ']')
        $htmlLog = $htmlLog + $taskLine + '<br>'
        if ($doEcho) { Write-Host ( $taskLine ) -ForegroundColor Red }
    }
} finally {
    if ($line) { try { Remove-Variable -Name line } catch {}}
    if ($process) { try { Remove-Variable -Name process } catch {}}
    if ($psi) { try { Remove-Variable -Name psi } catch {}}
    if ($vs2017Build) { try { Remove-Variable -Name vs2017Build } catch {} }
}
#endregion
##################################################################################################################
$taskName = 'build solution'
#region
##################################################################################################################
try {
    [string] $vs2017Build = 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild.exe'
    [System.Diagnostics.ProcessStartInfo] $psi
    [System.Diagnostics.Process] $process
    [string] $line = ''
    
    # log
    $answer = 'yes'
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'start:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doStep) { $answer = Read-Host -Prompt ( $taskLine ) }
    elseif ($doEcho) { Write-Host ( $taskLine ) }

    if ($answer -ne 'no' -and ($doDevelopment -or $doTest)) { 
        $psi = New-object System.Diagnostics.ProcessStartInfo 
        $psi.CreateNoWindow = $true 
        $psi.WorkingDirectory = $sql2x + '\' + 'SolutionNorSolutionPim'
        $psi.UseShellExecute = $false 
        $psi.RedirectStandardOutput = $true 
        $psi.RedirectStandardError = $true 
        $psi.FileName = $vs2017Build
        $psi.Arguments = @($sql2x + '\' + 'SolutionNorSolutionPim' + '\' + 'SolutionNorSolutionPim' + '.sln' + ' /target:build') 
        
        $process = New-Object System.Diagnostics.Process 
        $process.StartInfo = $psi 
        [void]$process.Start()
        do {
            # read
            [string] $line = $process.StandardOutput.ReadLine()
            Write-Host $line

            # log
            $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + $line
            $htmlLog = $htmlLog + $taskLine + '<br>'
            if ($doEcho) { Write-Host ( $taskLine ) }
        } while (!$process.HasExited)        
    }

    # log
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'end:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doEcho) { Write-Host ( $taskLine ) }
} catch [Exception] {
    if ($rethrow) {
        Write-Host ($taskName + ' ' + 'Exception; ' + $_.Exception.Message)
        throw [Exception] ('Failed to; ' + $taskName)
    } else {
        $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + ('Exception:' + ' ' + $taskName + ' ' + '[' +  $_.Exception.Message + ']' + ' ' + 'Line:[' + $_.InvocationInfo.ScriptLineNumber + ']')
        $htmlLog = $htmlLog + $taskLine + '<br>'
        if ($doEcho) { Write-Host ( $taskLine ) -ForegroundColor Red }
    }
} finally {
    if ($line) { try { Remove-Variable -Name line } catch {}}
    if ($process) { try { Remove-Variable -Name process } catch {}}
    if ($psi) { try { Remove-Variable -Name psi } catch {}}
    if ($vs2017Build) { try { Remove-Variable -Name vs2017Build } catch {} }
}
#endregion
##################################################################################################################
$taskName = 'mail status'
#region
##################################################################################################################
try {  
    $answer = 'yes'

    # log
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'start:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doStep) { $answer = Read-Host -Prompt ( $taskLine ) }
    elseif ($doEcho) { Write-Host ( $taskLine ) }

    if ($sendMail -and $answer -ne 'no' -and ($doDevelopment -or $doTest -or $mailAnyway)) { 
        $SMTPClient = New-Object System.Net.Mail.SmtpClient
        $SMTPClient.Port = 587
        $SMTPClient.Host = 'smtp.live.com'
        $SMTPClient.EnableSsl = $true
        $SMTPClient.Timeout = 10000;
        $SMTPClient.DeliveryMethod = ([System.Net.Mail.SmtpDeliveryMethod]::Network)
        $SMTPClient.UseDefaultCredentials = $false

        $SMTPClient.Credentials = New-Object System.Net.NetworkCredential( `
            'emailLog' , `
            'azureActiveDirectoryPassword' `
            );

        $emailMessage = New-Object System.Net.Mail.MailMessage
        $emailMessage.From = 'emailLog'
        $emailMessage.To.Add('emailPersonal@first.com')
        $emailMessage.Subject = ($env:computername + ' : ' + $MyInvocation.MyCommand.Name)
        $emailMessage.Body = $htmlLog
        $emailMessage.IsBodyHtml = $true
        $emailMessage.BodyEncoding = ([System.Text.UTF8Encoding]::UTF8)
        $emailMessage.DeliveryNotificationOptions = ([System.Net.Mail.DeliveryNotificationOptions]::OnFailure)

        $SMTPClient.Send( $emailMessage )
        $SMTPClient.Dispose()
    }

    # log
    $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + 'end:' + ' ' + $taskName
    $htmlLog = $htmlLog + $taskLine + '<br>'
    if ($doEcho) { Write-Host ( $taskLine ) }
} catch [Exception] {
    if ($rethrow) {
        Write-Host ($taskName + ' ' + 'Exception; ' + $_.Exception.Message)
        throw [Exception] ('Failed to; ' + $taskName)
    } else {
        $taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + ('Exception:' + ' ' + $taskName + ' ' + '[' +  $_.Exception.Message + ']' + ' ' + 'Line:[' + $_.InvocationInfo.ScriptLineNumber + ']')
        $htmlLog = $htmlLog + $taskLine + '<br>'
        if ($doEcho) { Write-Host ( $taskLine ) -ForegroundColor Red }
    }
} finally {
    if ($SMTPClient) { try { Remove-Variable -Name SMTPClient } catch {} }
    if ($emailMessage) { try { Remove-Variable -Name emailMessage } catch {} }
}   
#endregion
##################################################################################################################
$taskName = 'end script:'
#region
##################################################################################################################
$dateTimeStop = [System.DateTime]::UtcNow
$taskLine = [System.DateTime]::UtcNow.ToString() + ' ' + $taskName `
    + ' ' + '[' + $MyInvocation.MyCommand.Name `
    + ' ' + $MyInvocation.MyCommand.Arguments + ']' `
    + ' ' + 'from' + ' ' + '[' + $dateTimeStart + ']' `
    + ' ' + 'to' + ' ' + '[' + $dateTimeStop  + ']'
$htmlLog = $htmlLog + $taskLine + '<br>'
if ($doEcho) { Write-Host ( $taskLine ) }
#endregion
##################################################################################################################
$taskName = 'cleanup'
#region
##################################################################################################################
if ($sql2x) { try { Remove-Variable -Name sql2x } catch {} }
if ($startupDirectory) { try { Remove-Variable -Name startupDirectory } catch {} }

if ($mailAnyway) { try { Remove-Variable -Name mailAnyway } catch {} }
if ($answer) { try { Remove-Variable -Name answer } catch {} }
if ($taskLine) { try { Remove-Variable -Name taskLine } catch {} }
if ($taskName) { try { Remove-Variable -Name taskName } catch {} }

if ($returnHtml -and $htmlLog) { 
    try { $htmlLog; Remove-Variable -Name htmlLog; return } catch {} } 
elseif ($htmlLog) { 
    try { Remove-Variable -Name htmlLog } catch {} }
#endregion

