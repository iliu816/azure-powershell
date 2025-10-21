### Example 1:  Get Application Type Details
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationType"
Get-AzServiceFabricManagedClusterApplicationType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName
```

Get application type details.

### Example 2: Get Application Types by Cluster
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Get-AzServiceFabricManagedClusterApplicationType -ResourceGroupName $resourceGroupName -ClusterName $clusterName 
```

Get list of application types under specified cluster.
