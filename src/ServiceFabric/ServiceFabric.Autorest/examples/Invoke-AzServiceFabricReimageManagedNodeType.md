### Example 1: Reimage Specified Node(s) on NodeType
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricReimageManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node testNodeType_0, testNodeType_3
```

Reimage node 0 and 3 on the node type.

### Example 2: Reimage Specified Node(s) on NodeType UD by UD
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricReimageManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -UpdateType "ByUpgradeDomain" -Node testNodeType_0, testNodeType_3
```

Reimage specified nodes on the node type. Nodes will be reimaged in batches according to their assigned UD. If all selected nodes are in the same UD, they will be reimaged at the same time.

### Example 3: Reimage All Nodes on NodeType UD by UD
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricReimageManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -UpdateType "ByUpgradeDomain"
```

Reimage all nodes on the node type. Nodes will be reimaged in batches according to their assigned UD.
