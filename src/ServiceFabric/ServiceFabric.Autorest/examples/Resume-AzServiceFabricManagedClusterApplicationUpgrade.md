### Example 1: Resume Application Upgrade
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$version = "testVersionResourceId"
$applicationName = "testApplicationName"
$upgradeDomainName = "10"
Resume-AzServiceFabricManagedClusterApplicationUpgrade -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName -UpgradeDomainName $upgradeDomainName
```

If the application upgrade mode is manual, resumes the upgrade in the specified UD.
