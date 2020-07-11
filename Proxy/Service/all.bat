cls
set svcutil="C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\svcutil.exe" 
set contract="..\..\XXPrototypeDotNetFrameworkClassLibraryCrudeContract\bin\Debug\XXPrototypeDotNetFrameworkClassLibraryCrudeContract.dll"

rem %svcutil% /reference:%contract% http://NorPimRedoneBusiness.azurewebsites.net/Product/ProductService.svc					/config:output.config /noLogo 
rem %svcutil% /reference:%contract% http://NorPimRedoneBusiness.azurewebsites.net/Product/ProductCategoryService.svc			/mergeConfig /config:output.config /noLogo 
rem %svcutil% /reference:%contract% http://NorPimRedoneBusiness.azurewebsites.net/Default/DefaultUserActivityService.svc		/mergeConfig /config:output.config /noLogo 
rem %svcutil% /reference:%contract% http://NorPimRedoneBusiness.azurewebsites.net/Default/DiagnosticsService.svc				/mergeConfig /config:output.config /noLogo 
