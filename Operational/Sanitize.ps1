$match = 'bin'
Write-Host all $match directories

foreach ($directory_to_remove in dir -recurse -include $match | where { test-path $_.fullname } ) {
    Write-Host $directory_to_remove
    #Remove-Item –path $directory_to_remove –recurse
}

$match = 'obj'
Write-Host all $match directories

foreach ($directory_to_remove in dir -recurse -include $match | where { test-path $_.fullname } ) {
    Write-Host $directory_to_remove
    #Remove-Item –path $directory_to_remove –recurse
}

$match = 'packages'
Write-Host all $match directories

foreach ($directory_to_remove in dir -recurse -include $match | where { test-path $_.fullname } ) {
    Write-Host $directory_to_remove
    #Remove-Item –path $directory_to_remove –recurse
}
