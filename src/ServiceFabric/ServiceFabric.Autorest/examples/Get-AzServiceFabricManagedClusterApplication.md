### Example 1:  Get Application Details
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationName = "testApplication"
Get-AzServiceFabricManagedClusterApplication -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName
```

Get application details.

### Example 2: Get Applications by Cluster
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
Get-AzServiceFabricManagedClusterApplication -ResourceGroupName $resourceGroupName -ClusterName $clusterName
```

Get list of applications under specified cluster.
