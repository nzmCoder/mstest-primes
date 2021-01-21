dotnet clean
Get-ChildItem * -Include obj -Recurse | Remove-Item -Recurse
Get-ChildItem * -Include bin -Recurse | Remove-Item -Recurse
Get-ChildItem * -Include TestResults -Recurse | Remove-Item -Recurse
Remove-Item TestResults -Recurse 
