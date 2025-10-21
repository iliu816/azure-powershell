### Example 1:  Create Application
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$version = "testVersionResourceId"
$applicationName = "testApplicationName"
New-AzServiceFabricManagedClusterApplication -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Version $version -ApplicationName $applicationName
```

Create new application.
