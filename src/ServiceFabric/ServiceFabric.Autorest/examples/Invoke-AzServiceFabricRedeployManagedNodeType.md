### Example 1: Redeploy Specified Node(s) on NodeType
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Invoke-AzServiceFabricRedeployManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -Node testNodeType_0, testNodeType_3
```

Redeploy node 0 and 3 on the node type.
