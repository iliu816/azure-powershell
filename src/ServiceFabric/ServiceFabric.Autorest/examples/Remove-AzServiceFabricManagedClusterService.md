### Example 1: Remove Service
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationName = "testApplication"
$serviceName = "testService"
Remove-AzServiceFabricManagedClusterService -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName -ServiceName $serviceName
```

Remove service. This will delete the service.
