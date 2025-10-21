### Example 1: Remove Specified Node(s) from Node Type
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Remove-AzServiceFabricManagedNodeTypeNode -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node testNodeType_0, testNodeType_3
```

Removed specified nodes from specified node type.
