# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 4/6/2020 4:53:15 PM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.Azure.ExtractPassword
$username = 'emailPersonal@Second.com';
        $securePassword = ConvertTo-SecureString -String 'passwordPersonalStyleLargeEndingTwo' -AsPlainText -Force;
        $cred = New-Object System.Management.Automation.PSCredential ($username, $securePassword);
        Add-AzureRmAccount -Credential $cred;
        Select-AzureRmSubscription -SubscriptionName 'Free Trial'
        # extract publishing password from existing web app 
# write to password file
$Xml = [xml](Get-AzureRmWebAppPublishingProfile -Format:WebDeploy -ResourceGroupName Default-Web-EastUS2 -Name NorSolutionPimCore )
$PublishProfile = $Xml.FirstChild.ChildNodes[1]   
$PublishProfile.userPWD | Out-File -NoNewline 'C:\SQL2XProjects\SolutionNorSolutionPim\PrototypeASPNetCoreTemplateWebApplicationWithCrude\Operational\WebAppPassword.txt'
