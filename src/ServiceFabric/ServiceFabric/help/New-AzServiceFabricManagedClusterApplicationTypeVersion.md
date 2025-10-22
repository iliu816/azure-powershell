---
external help file: Az.ServiceFabric-help.xml
Module Name: Az.ServiceFabric
online version: https://learn.microsoft.com/powershell/module/az.servicefabric/new-azservicefabricmanagedclusterapplicationtypeversion
schema: 2.0.0
---

# New-AzServiceFabricManagedClusterApplicationTypeVersion

## SYNOPSIS
Create a Service Fabric managed application type version resource with the specified name.

## SYNTAX

### CreateExpanded (Default)
```
New-AzServiceFabricManagedClusterApplicationTypeVersion [-Version] <String> -ApplicationTypeName <String>
 [-ClusterName] <String> [-ResourceGroupName] <String> [-SubscriptionId <String>] [-AppPackageUrl <String>]
 [-Location <String>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzServiceFabricManagedClusterApplicationTypeVersion [-Version] <String> -ApplicationTypeName <String>
 [-ClusterName] <String> [-ResourceGroupName] <String> [-SubscriptionId <String>] -JsonString <String>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzServiceFabricManagedClusterApplicationTypeVersion [-Version] <String> -ApplicationTypeName <String>
 [-ClusterName] <String> [-ResourceGroupName] <String> [-SubscriptionId <String>] -JsonFilePath <String>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityManagedClusterExpanded
```
New-AzServiceFabricManagedClusterApplicationTypeVersion [-Version] <String> -ApplicationTypeName <String>
 -ManagedClusterInputObject <IServiceFabricIdentity> [-AppPackageUrl <String>] [-Location <String>]
 [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityApplicationTypeExpanded
```
New-AzServiceFabricManagedClusterApplicationTypeVersion [-Version] <String>
 -ApplicationTypeInputObject <IServiceFabricIdentity> [-AppPackageUrl <String>] [-Location <String>]
 [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create a Service Fabric managed application type version resource with the specified name.

## EXAMPLES

### Example 1:  Create Application Type Version
```powershell
$location = "testLocation"
$resourceGroupName = "testResourceGroup"
$clusterName = "testCluster"
$applicationTypeName = "testApplicationType"
$version = "testVersion"
$appPackageUrl = "testAppPackageUrl"
New-AzServiceFabricManagedClusterApplicationTypeVersion -Location $location -ResourceGroupName $resourceGroupName -ClusterName $clusterName -ApplicationTypeName $applicationTypeName -Version $version -AppPackageUrl $appPackageUrl
```

Create new application type version.

## PARAMETERS

### -ApplicationTypeInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IServiceFabricIdentity
Parameter Sets: CreateViaIdentityApplicationTypeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ApplicationTypeName
The name of the application type name resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonString, CreateViaJsonFilePath, CreateViaIdentityManagedClusterExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppPackageUrl
The URL to the application package

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityManagedClusterExpanded, CreateViaIdentityApplicationTypeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterName
The name of the cluster resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonString, CreateViaJsonFilePath
Aliases:

Required: True
Position: 1
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

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The geo-location where the resource lives

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityManagedClusterExpanded, CreateViaIdentityApplicationTypeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagedClusterInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IServiceFabricIdentity
Parameter Sets: CreateViaIdentityManagedClusterExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonString, CreateViaJsonFilePath
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonString, CreateViaJsonFilePath
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityManagedClusterExpanded, CreateViaIdentityApplicationTypeExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
The application type version.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: 3
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IServiceFabricIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ServiceFabric.Models.IApplicationTypeVersionResource

## NOTES

## RELATED LINKS
