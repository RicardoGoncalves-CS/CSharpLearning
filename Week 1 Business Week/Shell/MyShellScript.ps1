$folderPath = "~\Documents\Organize"

if (!(Test-Path $folderPath))
{
md $folderPath
}

$date = Get-Date -Format "dd-MM-yyyy"

$fullPath = $folderPath + "\" + $date

if (!(Test-Path $fullPath))
{
md $fullPath
echo "Folder $fullPath was successfully created."
}

mv ~\Desktop\* $fullPath
echo "All files and folders on Desktop have been moved to $fullPath."
