# Nor-Pim - Open Source

Nor-Pim is a Product Information Management System written for enterprise cloud environments with user interfaces tailored for PC, Web and Mobile. It is centered around Microsoft products like SQL Server, Azure, Visual Studio, C# and TypeScript.

A major part of the code is produced by a Code Generator [sql2x](www.sql2x.org). The general idea is to use as few frameworks and dependencies as possible in order to make a product that will stand the test of time without having to be rewritten when technology shifts happens and frameworks and dependencies become incompatible.

The remaining part of code mainly consists of user interface tweaks to support new user interface trends and fads, business layer code to interact with other systems, import/export, etc.

The example catalog and product data is all Latin "Lorem ipsum" Gibberish, this to take focus away from the data as any product related data can be handled by Nor-Pim.

The goal of Open Sourcing Nor-Pim is to attract organizations/developers to make user interfaces tailored towards more specialized businesses while keeping the core sturdy enough to handle both small and large sets of products as effective as possible on the infrastructure it runs on. 

Currently Nor-Pim runs on SQL Server using only Tables, Columns and Relations, no Stored Procedures or Functions. This makes Nor-Pim easily adaptable to other databases. Same with the business layer where dotNetCore under Linux is in the [pipeline](#pipeline). The business logic in the tailored code of Nor-Pim is not expected to change at all during this transition from WCF/SOAP to REST. And the tailored user interface code should stay the same as SQL2X provides the same client side proxy for REST interfaces as SOAP did.

Live [Nor-Pim running under Azure](http://www.Nor-Pim.com). In this configuration all 3 FrontEnds runs under one Azure App, the WCF/SOAP layer in another one and finally Azure SQL Database on a third server.

# Nor-Pim
[Nor-Pim](http://www.Nor-Pim.com) Product Information Management - Structured product specific attributes for Windows / Web and Mobile platform.

Nor-Pim is a Product Information Management System written for enterprise cloud environments with user interfaces tailored for PC, Web and Mobile.

Nor-Pim is used for managing structured product specific attributes which is either maintained manually or automatically through interfaces to other systems.

Nor-Pim provides full access to a product and it's structure with a fixed or customized API through WCF/SOAP interfaces.

Nor-Pim also acts as a proof of concept for a three tiered cloud based "Line-of-Business" system that features:

 - SQL Server database
 - Business layer through WCF/SOAP / ASP
 - FrontEnd's consuming the WCF/SOAP layer :
   - Windows application ( Full Maintenance Capabilities )
   - Web Site ( Browsing and editing products / product bucket )
   - Mobile Hybrid App ( Browsing and editing products / product bucket )

Nor-Pim uses no special frameworks outside of the dotNetFramework ecosystem in an effort to make it as scalable and maintainable as possible, this is made possible by using a tool to generate boiler plate code for efficient communication between layers ( SQL2X ). Since the code is bare bone C# and TypeScript it is easier to find developers to maintain / enhance the code.

## Visual Studio 2017
Nor-Pim requires Visual Studio 2017 which can be downloaded [here](https://visualstudio.microsoft.com/vs/older-downloads/)

You will need the following WorkLoad:
 - Azure
 - ManagedDesktop
 - NetWeb

## Code
 - [GitHub](https://github.com/aunebakk/nor-pim)
   - **GitHub CLI**: ```gh repo clone aunebakk/nor-pim```
   - **Git**: ```git clone https://github.com/aunebakk/nor-pim.git```
   - Compressed [zip](https://github.com/aunebakk/nor-pim/archive/master.zip) file

## Folder structure ( first level )
| Parameter                             | Comment                                                                           |
|---------------------------------------|-----------------------------------------------------------------------------------|
| Business                              | WCF / SOAP Business layer ( C# )
| Contract                              | Contracts used by the Data, Business, Web and WinForm Layers ( C# )
| Data                                  | Data Access Layer, used by the Business Layer ( C# / Ansi SQL )
| Database                              | Visual Studio testbed to SQL Server ( Ansi SQL ) & ErWin Schema
| DatabaseManager                       | Creates and Updates the database in SQL Server, Local and Azure ( C# / Ansi SQL )
| Documentation                         | Images / license file for this document
| Information                           | General information from the SQL2X creation process
| Operational                           | Scripts to Build and Deploy this product ( PowerShell and DOS )
| Proxy                                 | WCF / SOAP client proxy used in WinForm and Web / ASP ( C# )
| Web                                   | Hybrid / Web FrontEnd's ( C# / ASP & TypeScript / JavaScript / HTML / CSS )
| WinForm                               | Windows WinForm & Installer ( C# )

## How to run code on local computer
Use PowerShell to rename the sql server connection string for the various projects:

 - De-Sanitize Connection

| Parameter                             | Comment                                           |
|---------------------------------------|---------------------------------------------------|
| connectionStringSQLServer             | ADO connection string to a SQL Server
| **or**                                | 
| toSQLServerLocalTrusted               | Create a trusted ADO connection string to a local SQL Server

**From PowerShell**
```
# this will insert ADO connection strings to a local trusted sql server, typical for a development environment
& '.\Operational\De-Sanitize Connection.ps1' `
   -toSQLServerLocalTrusted:$true

& '.\Operational\Environment Switch.ps1' `
   -toRemote:$false
```
 **From Visual Studio 2017**
 - Clean build
 - Run DatabaseManager to create the Database and populate it's tables
 - Select Business and Web as startup
 - Run

## How to publish to azure
Use PowerShell to rename the sql server connection string and login information for the various projects:

Note, the user here is not the owner of the Azure account, but rather an Azure Active Directory Guest user.

| Parameter                             | Comment                                           |
|---------------------------------------|---------------------------------------------------|
| azureActiveDirectoryLogin             | Azure Active Directory Login eMail
| azureActiveDirectoryPassword          | Azure Active Directory Login password
| connectionStringSQLServer             | ADO connection string to SQL Server
| **or**                                | 
| toAzure                               | Create ADO connection string to a SQL Server
| sqlServerName                         | SQL server name
| sqlServerUserName                     | SQL server user name
| sqlServerPassword                     | SQL server password

**From PowerShell**
```
# this will insert ADO connection strings to an Azure sql server and Azure Web Apps
& '.\Operational\De-Sanitize Connection.ps1' `
  -toAzure:$true `
  -azureActiveDirectoryLogin:'roger@aunebakk.com' `
  -azureActiveDirectoryPassword:'en8to3FIRE2' `
  -sqlServerName:'hri0nhlzkl' `
  -sqlServerUserName:'norgate' `
  -sqlServerPassword:'njas42379HGI'

& '.\Operational\Environment Switch.ps1' `
   -toRemote:$true
```
**The Web and Window FrontEnd's**
```
 - NuGet.exe restore .\SolutionNorSolutionPim.sln ( Download NuGet here: https://docs.microsoft.com/en-us/nuget/release-notes/nuget-4.9-rtm )
 - & '.\Operational\Restore packages.bat'
 - & '.\WinForm\Operational\Publish WinForm layer to ASP site install directory.bat'
 - & '.\Web\Operational\Get-Web-App-PublishingProfile.ps1'
 - & '.\Web\Operational\Build package to disk.bat'
 - & '.\Web\Operational\Publish To Azure.bat'
```
At this point the FrontEnd can only be used to bring up the start page and the about box.

**The Business Layer**
```
 - & '.\Business\Operational\Get-Web-App-PublishingProfile.ps1'
 - & '.\Business\Operational\Build package to disk.bat'
 - & '.\Business\Operational\Publish To Azure.bat'
```
**The Database**

The web FrontEnd is responsible for creating and updating the database, so the FrontEnd needs to be published before the database can be created. 

 - https://XXX.azurewebsites.net/database
   - Database Management Create Database
   - Database Management Set Version Zero	Database
   - Database Management Increase Version To Latest step by step
   - Database Management Version Object ( Should be 0.14.0 )

*Feel free to test this against the live version of NorPim, there is absolutely no security measures in place to prevent this right now*

## Test

*Open URL to the published Hybrid/Web FrontEnd, you will find the starting point for the Windows version under Applications Tile*.

## This ReadMe
Is an top-down view of Nor-Pim, starting with all user visible aspects, going through the architecture from client proxies to business layer and the database.

## The Repository
This repository ("`Nor-Pim`") is where we ( NorGate ) develop the [Nor-Pim](http://Nor-Pim.com) product. This source code is available to everyone under the standard [MIT](https://github.com/aunebakk/nor-pim/blob/master/Documentation/license.txt) license.

## DashBoard
This is the starting page for the Hybrid Mobile/Web side of Nor-Pim. It supports portrait and landscape mode, so rotating a mobile device will change layout of tiles.

<p align="center">
  <img alt="Nor-Pim in action" src=".\Documentation\dashboard.png">
</p>

## Hybrid/Web Catalog Index view
This view is used for navigating the index of your products. It supports portrait and landscape mode, so rotating a mobile device will change layout of tiles. This view is the first level, clicking a tile will bring the user to level 2, then level 3 and finally to the product view.

<p align="center">
  <img alt="Nor-Pim in action" src=".\Documentation\catalog.png">
</p>

## Hybrid/Web Product view
This is the product selection view, it allows for "Selecting" a product into a "bucket", get Details about a product or Edit a product.
<p align="center">
  <img alt="Nor-Pim in action" src=".\Documentation\product.png">
</p>

## Hybrid/Web Detail view
The detail page allows the user to see all essential information about a product in a Web page.
<p align="center">
  <img alt="Nor-Pim in action" src=".\Documentation\product-detail.png">
</p>

## Hybrid/Web Edit page
The edit page allows the user to edit all essential information about a product in a Web page.

The user will have to Login in order to save any changes ( TODO )
<p align="center">
  <img alt="Nor-Pim in action" src=".\Documentation\product-edit.png">
</p>

## Windows Product Preview
The windows version features it's own installation and has access to everything Nor-Pim has to offer. 
<p align="center">
  <img alt="Nor-Pim in action" src=".\Documentation\Windows-Product-Preview.png">
</p>

## Windows Whiteboard
For editing all product data, including an all inclusive history of all changes done to the product. Support for Excel Copy and Paste.
<p align="center">
  <img alt="Nor-Pim in action" src=".\Documentation\Windows-Product-Whiteboard.png">
</p>

## Languages
 - C#
 - TypeScript / JavaScript ( minimal usage of HTML5 / CSS )
 - Ansi SQL

## Software architecture
 - [Schematic Overview](https://norsolutionsql2xcore.azurewebsites.net/api/1/dashboard/DashboardArchitectureFramework)
 - sql2x.org [Code Generator](https://norsolutionsql2xcore.azurewebsites.net/sql2xIndex)
 - dotNetFramework
 - WinForm
 - ASP
 - WCF

## System architecture
 - [Azure](https://norsolutionsql2xcore.azurewebsites.net/Azure)
 - SQL Server
 - IIS
 - Windows
 
 ## Security
 - On FrontEnd and SQL Server level. WCF/SOAP services level is in the [pipeline](#pipeline).
 
## Database
Following is parts of Nor-Pim's Database schema, there are more tables dealing with import and export, catalog structure, security and users.

Nor-Pim uses a database handler that takes care of upgrading database schemas from one version to another, making having multiple databases at different versions manageable.
<p align="center">
  <img alt="Nor-Pim DB Schema" src=".\Documentation\schema.png">
</p>

## Pipeline
 - WCF/SOAP Security / Winter 2020
 - Replace jQuery and Bootstrap / Winter 2021
 - dotNetCore / Spring 2021
 - Visual Studio 2019 / Spring 2021 

## Feedback

* Follow [@sql2x](https://twitter.com/sql2x) and let us know what you think!
* Follow [reddit](https://www.reddit.com/r/sql2x/) and let us know what you think!
* [File an issue ( GitHub issue tracker )](https://github.com/aunebakk/nor-pim/issues)
* [File an issue ( Nor-Pim's own issue tracker )](https://norsolutionpim.azurewebsites.net/DefaultIssueWithFilterLive/DefaultIssueWithFilterLiveIndex)
* Ask a question on [Stack Overflow](https://stackoverflow.com/questions/tagged/Nor-Pim)

## SQL2X
Nor-Pim is in large part made by an Visual Studio Extension named SQL2X. Metadata and Code from this tool is found around the codebase, indications are:
 - SchemaTemplates folders, these are .json files that directly corresponds to database tables and have no influence on how Nor-Pim runs but are used by the SQL2XLite extension.
 - CRUDE ( Create Read Update Delete & Extras ) folders are the direct result of SchemaTemplates .json files, i.e. automatic code generated by SQL2x, feel free to modify this code as you see fit, there are no other dependencies on this code except other layers that interact with it's methods.
 - Durian folders comes from Ansi SQL Select statements in the Data tier.
 - Operational folders contain PowerShell and Batch scripts used to recompile and republish that part of the product, our approach to CI/CD.

## License

Copyright (c) NorGate. All rights reserved.

Licensed under the [MIT](https://github.com/aunebakk/nor-pim/blob/master/Documentation/license.txt) license.
