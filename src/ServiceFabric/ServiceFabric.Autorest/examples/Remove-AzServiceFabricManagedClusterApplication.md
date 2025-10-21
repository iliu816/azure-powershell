### Example 1:  Remove Application
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationName = "testApplication"
Remove-AzServiceFabricManagedClusterApplication -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName
```

Remove application. This will delete the application.
