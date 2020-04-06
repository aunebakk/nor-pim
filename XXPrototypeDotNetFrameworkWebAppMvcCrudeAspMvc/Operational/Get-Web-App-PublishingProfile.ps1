# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 4/6/2020 4:54:41 PM
# Template: sql2x.AzureBase.ExecutePowerShell
# From: sql2x.AzureBase.WebAppPublishingProfileGet
$username = 'emailPersonal@Second.com';
        $securePassword = ConvertTo-SecureString -String 'passwordPersonalStyleLargeEndingTwo' -AsPlainText -Force;
        $cred = New-Object System.Management.Automation.PSCredential ($username, $securePassword);
        Add-AzureRmAccount -Credential $cred;
        Select-AzureRmSubscription -SubscriptionName 'Free Trial'
        Get-AzureRmWebAppPublishingProfile  `
 -Name NorSolutionPim `
 -OutputFile C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkWebAppMvcCrudeAspMvc\Operational\NorSolutionPim.publishSettings `
 -Format WebDeploy `
 -ResourceGroupName Default-Web-EastUS2