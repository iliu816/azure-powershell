### Example 1: Get Zone Resiliency Status
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Get-AzServiceFabricManagedAzResiliencyStatus -ResourceGroupName $resourceGroupName -ClusterName $clusterName
```

Get the availability zone resiliency status for the specified cluster.
