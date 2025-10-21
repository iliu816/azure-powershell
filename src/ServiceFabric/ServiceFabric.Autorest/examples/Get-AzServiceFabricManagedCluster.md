### Example 1: Get Cluster Details
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Get-AzServiceFabricManagedCluster -ResourceGroupName $resourceGroupName -ClusterName $clusterName
```

Get cluster details.

### Example 2: Get Cluster Details by Resource Group
```powershell
$resourceGroupName = "testResourceGroup"
Get-AzServiceFabricManagedCluster -ResourceGroupName $resourceGroupName
```

Get list of clusters under the specified resource group.

### Example 2: Get Cluster Details by Subscription
```powershell
Get-AzServiceFabricManagedCluster
```

Get list of clusters under the current subscription.
