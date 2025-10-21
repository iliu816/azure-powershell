---
external help file: Az.ServiceFabric-help.xml
Module Name: Az.ServiceFabric
online version: https://learn.microsoft.com/powershell/module/az.servicefabric/get-azservicefabricmanagedclusterversion
schema: 2.0.0
---

# Get-AzServiceFabricManagedClusterVersion

## SYNOPSIS
Gets information about an available Service Fabric cluster code version by environment.

## SYNTAX

### List (Default)
```
Get-AzServiceFabricManagedClusterVersion -Location <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentityLocation1
```
Get-AzServiceFabricManagedClusterVersion -ClusterVersion <String>
 -Location1InputObject <IServiceFabricIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentityLocation
```
Get-AzServiceFabricManagedClusterVersion -ClusterVersion <String> -LocationInputObject <IServiceFabricIdentity>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get1
```
Get-AzServiceFabricManagedClusterVersion -ClusterVersion <String> -Location <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzServiceFabricManagedClusterVersion -ClusterVersion <String> -Location <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List1
```
Get-AzServiceFabricManagedClusterVersion -Location <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-AzServiceFabricManagedClusterVersion -InputObject <IServiceFabricIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzServiceFabricManagedClusterVersion -InputObject <IServiceFabricIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets information about an available Service Fabric cluster code version by environment.

## EXAMPLES

### Example 1: Get Cluster Code Versions by Location
```powershell
$location = "southcentralus"
Get-AzServiceFabricManagedClusterVersion -Location $location
```

```output
Name           ResourceGroupName
----           -----------------
9.1.1387.9590
9.1.1390.9590
9.1.1436.9590
9.1.1566.9590
9.1.1583.9590
9.1.1653.9590
9.1.1780.9590
9.1.1799.9590
9.1.1833.9590
9.1.1851.9590
9.1.1993.9590
9.1.2111.9590
9.1.2139.9590
9.1.2277.9590
9.1.2488.9590
9.1.2574.9590
9.1.2718.9590
9.1.2833.9590
9.1.2837.9590
9.1.2971.9590
9.1.3023.9590
10.0.1779.9590
10.0.1816.9590
10.0.1903.9590
10.0.1949.9590
10.0.2025.9590
10.0.2053.9590
10.0.2189.9590
10.0.2226.9590
10.0.2382.9590
10.0.2467.9590
10.0.2604.9590
10.0.2712.9590
10.0.2717.9590
10.0.2744.9590
10.0.2827.9590
10.0.2899.9590
10.0.2978.9590
10.1.1475.9590
10.1.1541.9590
10.1.1612.9590
10.1.1656.9590
10.1.1740.9590
10.1.1772.9590
10.1.1911.9590
10.1.1951.9590
10.1.2113.9590
10.1.2175.9590
10.1.2203.9590
10.1.2338.9590
10.1.2448.9590
10.1.2474.9590
10.1.2493.9590
10.1.2617.9590
10.1.2722.9590
10.1.2796.9590
10.1.2841.9590
10.1.2907.9590
10.1.2928.9590
10.1.2941.9590
10.1.2986.1
10.1.2994.1
10.1.3006.1
10.1.3008.1
10.1.3015.1
11.0.0.0
11.0.2619.1
11.0.2639.1
11.0.2666.1
11.0.2707.1
11.1.200.1
11.1.205.1
11.1.208.1
11.2.217.1
11.2.225.1
11.2.274.1
11.3.282.1
11.3.299.1
11.3.304.1
11.3.365.1
```

Get available cluster code versions by location.

## PARAMETERS

### -ClusterVersion
The cluster code version.

```yaml
Type: System.String
Parameter Sets: GetViaIdentityLocation1, GetViaIdentityLocation, Get1, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IServiceFabricIdentity
Parameter Sets: GetViaIdentity1, GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Location
The location for the cluster code versions.
This is different from cluster location.

```yaml
Type: System.String
Parameter Sets: List, Get1, Get, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location1InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IServiceFabricIdentity
Parameter Sets: GetViaIdentityLocation1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LocationInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IServiceFabricIdentity
Parameter Sets: GetViaIdentityLocation
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: List, Get1, Get, List1
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IServiceFabricIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IManagedClusterCodeVersionResult

## NOTES

## RELATED LINKS
