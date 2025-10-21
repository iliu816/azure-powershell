### Example 1: Get Service Details
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationName = "testApplication"
$serviceName = "testService"
Get-AzServiceFabricManagedClusterService -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName -ServiceName $serviceName
```

Get service details.

### Example 2: Get Service Details by Application
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationName = "testApplication"
Get-AzServiceFabricManagedClusterService -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName
```

Get service details under the specified application.
