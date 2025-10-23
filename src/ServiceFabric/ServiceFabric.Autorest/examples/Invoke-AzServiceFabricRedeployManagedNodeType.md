### Example 1: Redeploy Specified Node(s) on NodeType
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricRedeployManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node testNodeType_0, testNodeType_3
```

Redeploy node 0 and 3 on the node type.

### Example 2: Redeploy Specified Node(s) on NodeType UD by UD
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricRedeployManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -UpdateType "ByUpgradeDomain" -Node testNodeType_0, testNodeType_3
```

Redeploy specified nodes on the node type. Nodes will be redeployed in batches according to their assigned UD. If all selected nodes are in the same UD, they will be redeployed at the same time.

### Example 3: Redeploy All Nodes on NodeType UD by UD
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricRedeployManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -UpdateType "ByUpgradeDomain"
```

Redeploy all nodes on the node type. Nodes will be redeployed in batches according to their assigned UD.
