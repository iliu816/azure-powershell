### Example 1: Update Application Tags
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$name = "testName"
$tag = @{"testKey" = "testValue"}
Update-AzServiceFabricManagedClusterApplication -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Name $name -Tag $tags
```

Update application tags.
