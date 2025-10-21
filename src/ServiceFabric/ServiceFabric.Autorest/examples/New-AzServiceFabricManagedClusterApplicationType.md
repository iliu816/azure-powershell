### Example 1:  Create Application Type
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationType"
New-AzServiceFabricManagedClusterApplicationType -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName
```

Create new application type.
