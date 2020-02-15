# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 2/15/2020 5:36:57 AM
# Template: sql2x.Azure.ExecutePowerShell
# From: sql2x.Azure.WebAppPublishingProfileGet
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
