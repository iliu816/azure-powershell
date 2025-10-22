### Example 1: Fetch Application Upgrade Status
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$version = "testVersionResourceId"
$applicationName = "testApplicationName"
Read-AzServiceFabricManagedClusterApplicationUpgrade -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName
```

Fetch upgrade status details.
