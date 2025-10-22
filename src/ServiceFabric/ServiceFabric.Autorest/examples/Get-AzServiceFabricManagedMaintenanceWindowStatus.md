### Example 1: Get Maintenance Windows Status
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Get-AzServiceFabricManagedMaintenanceWindowStatus -ResourceGroupName $resourceGroupName -ClusterName $clusterName
```

Get the maintenance windows status for the specified cluster.
