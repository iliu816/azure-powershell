### Example 1: Update Cluster Tags
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$tag = @{"testKey" = "testValue"}
Update-AzServiceFabricManagedCluster -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Tag $tags
```

Update managed cluster tags.
