# SQL2X Generated code based on a SQL Server Schema
# SQL2X Version: 1.0
# http://sql2x.org/
# Generated Date: 4/25/2020 8:20:54 AM
# Template: sql2x.PrototypeDotNetCoreTwoOoneV3.Content_extractPasswordDOTps1
# extract publishing password from existing web app 
# Add-AzureAccount
# write to password file
$Xml = [xml](Get-AzureRmWebAppPublishingProfile -Format:WebDeploy -ResourceGroupName Default-Web-EastUS2 -Name NorSolutionPimCore )
$PublishProfile = $Xml.FirstChild.ChildNodes[1]   
$PublishProfile.userPWD | Out-File -NoNewline 'WebAppPassword.txt'
