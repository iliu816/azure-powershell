### Example 1: Create Cluster
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$sku = "Standard"
$dnsName = "testDnsName"
$adminUserName = "testAdminUserName"
$adminPassword = ConvertTo-SecureString -String "****" -AsPlainText -Force
$dnsName = "testDnsName"
$clientConnectionPort = 19000
$httpGatewayConnectionPort = 19080
$tag = @{"testKey" = "testValue"}
New-AzServiceFabricManagedCluster -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Sku $sku -AdminUserName $adminUserName -AdminPassword $adminPassword -DnsName $dnsName -ClientConnectionPort $clientConnectionPort -HttpGatewayConnectionPort $httpGatewayConnectionPort -Tag $tags
```

Create a managed cluster with Standard Sku.

### Example 2: Create Cluster with Client Authentication via Entra
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$sku = "Standard"
$dnsName = "testDnsName"
$adminUserName = "testAdminUserName"
$adminPassword = ConvertTo-SecureString -String "****" -AsPlainText -Force
$dnsName = "testDnsName"
$clientConnectionPort = 19000
$httpGatewayConnectionPort = 19080
$azureActiveDirectoryTenantId = "testAzureActiveDirectoryTenantId"
$azureActiveDirectoryClusterApplication = "testAzureActiveDirectoryClusterApplicationId"
$azureActiveDirectoryClientApplication = "testAzureActiveDirectoryClientApplicationId"
$tag = @{"testKey" = "testValue"}
New-AzServiceFabricManagedCluster -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Sku $sku -AdminUserName $adminUserName -AdminPassword $adminPassword -DnsName $dnsName -ClientConnectionPort $clientConnectionPort -HttpGatewayConnectionPort $httpGatewayConnectionPort -AzureActiveDirectoryTenantId $azureActiveDirectoryTenantId -AzureActiveDirectoryClusterApplication $azureActiveDirectoryClusterApplication -AzureActiveDirectoryClientApplication $azureActiveDirectoryClientApplication -Tag $tags
```

If a Microsoft Entra application has already been created with the correct permissions such as described at [Set up Microsoft Entra ID for client authentication in the Azure portal](https://learn.microsoft.com/en-us/azure/service-fabric/service-fabric-cluster-creation-setup-azure-ad-via-portal), the cluster can be configured to allow access.

### Example 3: Create Cluster with Client Authentication via Certificate Thumbprint
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$sku = "Standard"
$dnsName = "testDnsName"
$adminUserName = "testAdminUserName"
$adminPassword = ConvertTo-SecureString -String "****" -AsPlainText -Force
$dnsName = "testDnsName"
$clientConnectionPort = 19000
$httpGatewayConnectionPort = 19080
$clientCertificate = @(
    @{
        Thumbprint = "testThumbprint"
        IssuerThumbprint = "testIssuerThumbprint"
        IsAdmin = $true
    }
)
$tag = @{"testKey" = "testValue"}
New-AzServiceFabricManagedCluster -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Sku $sku -AdminUserName $adminUserName -AdminPassword $adminPassword -DnsName $dnsName -ClientConnectionPort $clientConnectionPort -HttpGatewayConnectionPort $httpGatewayConnectionPort -ClientCertificate $clientCertificate -Tag $tags
```

Create a cluster with a specified admin client certificate by thumbprint.

### Example 4: Create Cluster with Client Authentication via Certificate Common Name
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$sku = "Standard"
$dnsName = "testDnsName"
$adminUserName = "testAdminUserName"
$adminPassword = ConvertTo-SecureString -String "****" -AsPlainText -Force
$dnsName = "testDnsName"
$clientConnectionPort = 19000
$httpGatewayConnectionPort = 19080
$clientCertificate = @(
    @{
        CommonName = "testCommonName"
        IssuerThumbprint = "testIssuerThumbprint"
        IsAdmin = $false
    }
)
$tag = @{"testKey" = "testValue"}
New-AzServiceFabricManagedCluster -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Sku $sku -AdminUserName $adminUserName -AdminPassword $adminPassword -DnsName $dnsName -ClientConnectionPort $clientConnectionPort -HttpGatewayConnectionPort $httpGatewayConnectionPort -ClientCertificate $clientCertificate -Tag $tags
```

Create a cluster with a specified admin client certificate by common name.
