### Example 1: Update Node Type Tags
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$name = "testName"
$tag = @{"testKey" = "testValue"}
Update-AzServiceFabricManagedCluster -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Name $name -Tag $tags
```

Update node type tags.

### Example 2: Update Node Type Capacity
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$name = "testName"
$skuCapacity = 5

Update-AzServiceFabricManagedCluster -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Name $name -SkuCapacity $skuCapacity -Tag $tags
```

Update node type tags.
