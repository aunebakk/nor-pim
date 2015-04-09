set svcutil="C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools\svcutil.exe" 

%svcutil% http://norpim2ws.azurewebsites.net/Diagnostics/DiagnosticsService.svc				 /config:output.config /noLogo /namespace:*,norpim.BusinessLogicLayer.Other
%svcutil% http://norpim2ws.azurewebsites.net/Gather/GatherService.svc			/mergeConfig /config:output.config /noLogo /namespace:*,norpim.BusinessLogicLayer.Other
%svcutil% http://norpim2ws.azurewebsites.net/Product/ProductCategoryService.svc	/mergeConfig /config:output.config /noLogo /namespace:*,norpim.BusinessLogicLayer.Other
%svcutil% http://norpim2ws.azurewebsites.net/Product/ProductService.svc			/mergeConfig /config:output.config /noLogo /namespace:*,norpim.BusinessLogicLayer.Other
%svcutil% http://norpim2ws.azurewebsites.net/User/ActivityService.svc			/mergeConfig /config:output.config /noLogo /namespace:*,norpim.BusinessLogicLayer.Other
