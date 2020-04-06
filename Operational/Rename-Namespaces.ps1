# 2018.03.13 Added match option
# 2018.03.13 Remember that . (PERIOD) is a wildchar
Clear-Host
$find = 'NorPim\.'
$replace = 'NorSolutionPim.'
$match = '*.cshtml' , '*.cs', '*.svc'

foreach ($sc in dir -recurse -include $match | where { test-path $_.fullname -pathtype leaf} ) {
    select-string -path $sc -pattern $find
        (get-content $sc) | foreach-object { $_ -replace $find, $replace } | set-content $sc
        #(get-content $sc) | foreach-object { $_ -match $find } | out-null
}
