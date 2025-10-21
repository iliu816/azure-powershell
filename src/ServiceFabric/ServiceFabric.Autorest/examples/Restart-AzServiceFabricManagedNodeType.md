### Example 1: Restart Specified Node(s) on NodeType
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Restart-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node testNodeType_0, testNodeType_3
```

Restart node 0 and 3 on the node type.
