### Example 1: Deallocate Specified Node(s) on NodeType
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricDeallocateManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node testNodeType_0, testNodeType_3
```

Deallocate node 0 and 3 on the node type.
