### Example 1: Removed Cluster
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Remove-AzServiceFabricManagedCluster -ResourceGroupName $resourceGroupName -ClusterName $clusterName
```

Remove the cluster. This will delete the cluster.
