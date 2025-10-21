### Example 1: Create Primary Node Type
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
$vmSize = "testVmSize"
$vmInstanceCount = 5
$vmSharedGalleryImageId = "/SharedGalleries/WindowsServer.1P.Canary/Images/2022-DATACENTER-AZURE-EDITION/Versions/latest"
$dataDiskSizeGB = 120
$dataDiskType = "StandardSSD_ZRS"
$zone = @("1", "2", "3")
$tag = @{"testKey" = "testValue"}
New-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -VMSize $vmSize -VMInstanceCount $vmInstanceCount -DataDiskSizeGB $dataDiskSizeGB -VMSharedGalleryImageId $vmSharedGalleryImageId -IsPrimary -Zone $zone -Tag $tags
```

Create a primary node type with a managed data disk and 1P gallery image across 3 availability zones. Cluster must have automatic OS upgrades enabled for 1P gallery image.

### Example 2: Create Secondary Node Type
```powershell
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$nodeTypeName = "testNodeType"
$vmSize = "testVmSize"
$vmInstanceCount = 5
$vmImagePublisher = "MicrosoftWindowsServer"
$vmImageOffer = "WindowsServer"
$vmImageSku = "2022-DataCenter-G2"
$vmImageVersion = "latest"
$dataDiskSizeGB = 120
$placementProperty = @{
    SomeProperty = "Test"
}
$tag = @{"testKey" = "testValue"}
New-AzServiceFabricManagedNodeType -ResourceGroupName $resourceGroupName -ClusterName $clusterName -NodeTypeName $nodeTypeName -VMSize $vmSize -VMInstanceCount $vmInstanceCount -DataDiskSizeGB $dataDiskSizeGB -VMImagePublisher $vmImagePublisher -VMImageOffer $vmImageOffer -VMImageSku $vmImageSku -VMImageVersion $vmImageVersion -PlacementProperty $placementProperty -IsStateless -Tag $tags
```

Create a non-primary node type with placement properties and marked to host stateless workloads.
