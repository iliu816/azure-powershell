### Example 1: Update Service Tags
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationName = "testApplicationName"
$name = "testName"
$tag = @{"testKey" = "testValue"}
Update-AzServiceFabricManagedClusterService -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName -Name $name -Tag $tags
```

Update service tags.
