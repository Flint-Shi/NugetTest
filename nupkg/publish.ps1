# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
#��ȡ��Ŀ·����Ϣ
 
$anem= Dir -name
   
Write-Host "$anem "
Write-Host "$packFolder "




# List of projects
$projects = (
    "FlintTest"  
)

# Copy all nuget packages to the pack folder
foreach ($project in $projects) {
    
    $projectFolder = Join-Path $srcPath $project

  

    # Create nuget pack
   # Set-Location $projectFolder
  
  
 
  

 # $projectPackPath = Join-Path $projectFolder ("/bin/Release/" + $project + ".*.nupkg")


}
 