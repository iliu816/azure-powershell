### Example 1: Apply Maintenance Windows
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Invoke-AzServiceFabricManagedApplyMaintenanceWindow -ResourceGroupName $resourceGroupName -ClusterName $clusterName
```

Apply a maintenance windows for the specified cluster right now.
