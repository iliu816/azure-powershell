### Example 1: List Unsupported VM Sizes
```powershell
$location = "southcentralus"
Get-AzServiceFabricManagedUnsupportedVmSize -Location $location
```

Get the lists of unsupported VM sizes for Service Fabric Managed Clusters.

### Example 2: Get Unsupported VM Size
```powershell
$vmSize = "Standard_B8s_v2"
$location = "southcentralus"
Get-AzServiceFabricManagedUnsupportedVmSize -Location $location -VMSize $vmSize
```

Get unsupported VM Size for Service Fabric Managed Clusters.
