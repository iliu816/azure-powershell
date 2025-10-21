### Example 1: Start Specified Node(s) on NodeType
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Start-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node BE_0, BE_3
```

Start node 0 and 3 on the node type.
