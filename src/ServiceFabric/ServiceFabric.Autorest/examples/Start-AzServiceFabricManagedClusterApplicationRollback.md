### Example 1: Start Application Upgrade Rollback
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$version = "testVersionResourceId"
$applicationName = "testApplicationName"
Start-AzServiceFabricManagedClusterApplicationRollback -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName
```

Attempts to initiate a rollback of the current ongoing application upgrade. If there is no upgrade in progress, this operation will not do anything.
