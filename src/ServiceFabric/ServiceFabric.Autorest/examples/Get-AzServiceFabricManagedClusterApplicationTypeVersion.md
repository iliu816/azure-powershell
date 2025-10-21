### Example 1:  Get Application Type Version Details
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationType"
$version = "testVersion"
Get-AzServiceFabricManagedClusterApplicationTypeVersion -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName -Version $version
```

Get application type version details.

### Example 2: Get Application Type Versions by Application Type
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationType"
Get-AzServiceFabricManagedClusterApplicationTypeVersion -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName
```

Get list of application type versions under specified application type.
