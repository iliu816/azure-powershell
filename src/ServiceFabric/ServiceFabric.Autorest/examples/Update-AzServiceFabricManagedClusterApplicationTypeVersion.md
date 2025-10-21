### Example 1: Update Application Type Version Tags
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationTypeName"
$version = "testVersion"
$tag = @{"testKey" = "testValue"}
Update-AzServiceFabricManagedClusterApplicationTypeVersion -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName -Version $version -Tag $tags
```

Update application type version tags.
