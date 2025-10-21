### Example 1: Update Application Type Tags
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$name = "testName"
$tag = @{"testKey" = "testValue"}
Update-AzServiceFabricManagedClusterApplicationType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Name $name -Tag $tags
```

Update application type tags.
