### Example 1:  Create Service
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationName = "testApplicationName"
$serviceKind = "Stateless"
$serviceTypeName = "testServiceType"
$serviceName = "testService"
$partitionDescriptionPartitionScheme
New-AzServiceFabricManagedClusterService -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationName $applicationName -ServiceKind $serviceKind -ServiceTypeName $serviceTypeName -ServiceName $serviceName 
```

Create new service.
