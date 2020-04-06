$match = '*.bak'

foreach ($bak_file in dir -recurse -include $match | where { test-path $_.fullname -pathtype leaf} ) {
    Write-Host $bak_file
    Remove-Item $bak_file
}
