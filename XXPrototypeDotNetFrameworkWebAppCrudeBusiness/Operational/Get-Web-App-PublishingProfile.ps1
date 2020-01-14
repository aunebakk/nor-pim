# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 1/14/2020 7:38:34 AM
# Template: sql2x.Azure.ExecutePowerShell
# From: sql2x.Azure.WebAppPublishingProfileGet
$username = 'emailPersonal@Second.com';
$securePassword = ConvertTo-SecureString -String 'passwordPersonalStyleLargeEndingTwo' -AsPlainText -Force;
$cred = New-Object System.Management.Automation.PSCredential ($username, $securePassword);
Add-AzureRmAccount -Credential $cred;
Select-AzureRmSubscription -SubscriptionName 'Free Trial'
Get-AzureRmWebAppPublishingProfile  `
 -Name NorSolutionPimBusiness `
 -OutputFile C:\SQL2XProjects\SolutionNorSolutionPim\XXPrototypeDotNetFrameworkWebAppCrudeBusiness\Operational\NorSolutionPimBusiness.publishSettings `
 -Format WebDeploy `
 -ResourceGroupName Default-Web-EastUS2
