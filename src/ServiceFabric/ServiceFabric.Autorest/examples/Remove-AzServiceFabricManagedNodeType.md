### Example 1: Removed Specified Node Type
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Remove-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName
```

Remove the node type from the cluster. This will delete the node type.
