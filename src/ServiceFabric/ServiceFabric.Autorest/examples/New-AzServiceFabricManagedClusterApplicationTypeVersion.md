### Example 1:  Create Application Type Version
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationType"
$version = "testVersion"
$appPackageUrl = "testAppPackageUrl"
New-AzServiceFabricManagedClusterApplicationTypeVersion -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName -Version $version -AppPackageUrl $appPackageUrl
```

Create new application type version.
