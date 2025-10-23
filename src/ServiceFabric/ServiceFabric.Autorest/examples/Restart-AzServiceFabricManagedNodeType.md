### Example 1: Restart Specified Node(s) on NodeType
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Restart-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node testNodeType_0, testNodeType_3
```

Restart node 0 and 3 on the node type.

### Example 2: Restart Specified Node(s) on NodeType UD by UD
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Restart-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -UpdateType "ByUpgradeDomain" -Node testNodeType_0, testNodeType_3
```

Restart specified nodes on the node type. Nodes will be restarted in batches according to their assigned UD. If all selected nodes are in the same UD, they will be restarted at the same time.

### Example 3: Restart All Nodes on NodeType UD by UD
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Restart-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -UpdateType "ByUpgradeDomain"
```

Restart all nodes on the node type. Nodes will be restarted in batches according to their assigned UD.
