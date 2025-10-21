### Example 1:  Remove Application Type
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationType"
Remove-AzServiceFabricManagedClusterApplicationType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName
```

Remove application type.
