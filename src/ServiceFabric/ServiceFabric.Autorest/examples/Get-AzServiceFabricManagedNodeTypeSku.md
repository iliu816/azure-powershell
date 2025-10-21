### Example 1: Get Node Type Supported Skus
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
Get-AzServiceFabricManagedNodeTypeSku -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName
```

Get a Service Fabric node type supported SKUs.
