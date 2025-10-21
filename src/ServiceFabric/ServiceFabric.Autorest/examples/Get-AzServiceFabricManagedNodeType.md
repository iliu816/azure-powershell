### Example 1: Get Node Type Details
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Get-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName
```

Get node type details.

### Example 2: Get Node Type Details by Cluster
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Get-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName
```

Get node type details under the specified cluster.
