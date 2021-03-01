# dotnet clean
Get-ChildItem * -Include obj -Recurse | Remove-Item -Recurse -ErrorAction Ignore
Get-ChildItem * -Include bin -Recurse | Remove-Item -Recurse -ErrorAction Ignore
Remove-Item PrimeService.Tests\TestResults -Recurse -ErrorAction Ignore
Remove-Item ref -Recurse -ErrorAction Ignore
Remove-Item *.exe -ErrorAction Ignore
Remove-Item *.dll -ErrorAction Ignore
Remove-Item *.json -ErrorAction Ignore
