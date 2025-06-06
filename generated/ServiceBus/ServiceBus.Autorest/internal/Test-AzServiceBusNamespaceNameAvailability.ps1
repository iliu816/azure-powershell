
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Check the give namespace name availability.
.Description
Check the give namespace name availability.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ICheckNameAvailability
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ICheckNameAvailabilityResult
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PARAMETER <ICheckNameAvailability>: Description of a Check Name availability request properties.
  Name <String>: The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens. The namespace must start with a letter, and it must end with a letter or number.
.Link
https://learn.microsoft.com/powershell/module/az.servicebus/test-azservicebusnamespacenameavailability
#>
function Test-AzServiceBusNamespaceNameAvailability {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ICheckNameAvailabilityResult])]
[CmdletBinding(DefaultParameterSetName='CheckExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials that uniquely identify a Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Check', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.ICheckNameAvailability]
    # Description of a Check Name availability request properties.
    ${Parameter},

    [Parameter(ParameterSetName='CheckExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.String]
    # The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens.
    # The namespace must start with a letter, and it must end with a letter or number.
    ${Name},

    [Parameter(ParameterSetName='CheckViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Check operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='CheckViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Body')]
    [System.String]
    # Json string supplied to the Check operation
    ${JsonString},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            Check = 'Az.ServiceBus.private\Test-AzServiceBusNamespaceNameAvailability_Check';
            CheckExpanded = 'Az.ServiceBus.private\Test-AzServiceBusNamespaceNameAvailability_CheckExpanded';
            CheckViaJsonFilePath = 'Az.ServiceBus.private\Test-AzServiceBusNamespaceNameAvailability_CheckViaJsonFilePath';
            CheckViaJsonString = 'Az.ServiceBus.private\Test-AzServiceBusNamespaceNameAvailability_CheckViaJsonString';
        }
        if (('Check', 'CheckExpanded', 'CheckViaJsonFilePath', 'CheckViaJsonString') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
