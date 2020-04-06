# 2018.03.05 works fine, stupid to use -replace instead of the appropriate method ( which is not -find ), but hey, it works
# 2018.03.12 using -match instead of -replace
$find = 'NorPimTestCore'
$match = '*.cshtml' , '*.cs', '*.svc'

foreach ($file in dir -recurse -include $match | where { test-path $_.fullname -pathtype leaf} ) {
    select-string -path $file -pattern $find 
        ( get-content $file ) | foreach-object { $_ -match $find } | out-null       
}
