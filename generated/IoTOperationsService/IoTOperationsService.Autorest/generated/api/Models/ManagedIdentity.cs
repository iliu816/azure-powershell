// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>System and Use Assigned Managed Identity properties</summary>
    public partial class ManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IManagedIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IManagedIdentityInternal
    {

        /// <summary>Internal Acessors for SystemAssignedManagedIdentitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentity Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IManagedIdentityInternal.SystemAssignedManagedIdentitySetting { get => (this._systemAssignedManagedIdentitySetting = this._systemAssignedManagedIdentitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowEndpointAuthenticationSystemAssignedManagedIdentity()); set { {_systemAssignedManagedIdentitySetting = value;} } }

        /// <summary>Internal Acessors for UserAssignedManagedIdentitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentity Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IManagedIdentityInternal.UserAssignedManagedIdentitySetting { get => (this._userAssignedManagedIdentitySetting = this._userAssignedManagedIdentitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowEndpointAuthenticationUserAssignedManagedIdentity()); set { {_userAssignedManagedIdentitySetting = value;} } }

        /// <summary>Backing field for <see cref="SystemAssignedManagedIdentitySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentity _systemAssignedManagedIdentitySetting;

        /// <summary>System-assigned managed identity authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentity SystemAssignedManagedIdentitySetting { get => (this._systemAssignedManagedIdentitySetting = this._systemAssignedManagedIdentitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowEndpointAuthenticationSystemAssignedManagedIdentity()); set => this._systemAssignedManagedIdentitySetting = value; }

        /// <summary>
        /// Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string SystemAssignedManagedIdentitySettingAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentityInternal)SystemAssignedManagedIdentitySetting).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentityInternal)SystemAssignedManagedIdentitySetting).Audience = value ?? null; }

        /// <summary>Backing field for <see cref="UserAssignedManagedIdentitySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentity _userAssignedManagedIdentitySetting;

        /// <summary>User-assigned managed identity authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentity UserAssignedManagedIdentitySetting { get => (this._userAssignedManagedIdentitySetting = this._userAssignedManagedIdentitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.DataflowEndpointAuthenticationUserAssignedManagedIdentity()); set => this._userAssignedManagedIdentitySetting = value; }

        /// <summary>Client ID for the user-assigned managed identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentitySettingClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentityInternal)UserAssignedManagedIdentitySetting).ClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentityInternal)UserAssignedManagedIdentitySetting).ClientId = value ?? null; }

        /// <summary>
        /// Resource identifier (application ID URI) of the resource, affixed with the .default suffix.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentitySettingScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentityInternal)UserAssignedManagedIdentitySetting).Scope; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentityInternal)UserAssignedManagedIdentitySetting).Scope = value ?? null; }

        /// <summary>Tenant ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentitySettingTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentityInternal)UserAssignedManagedIdentitySetting).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentityInternal)UserAssignedManagedIdentitySetting).TenantId = value ?? null; }

        /// <summary>Creates an new <see cref="ManagedIdentity" /> instance.</summary>
        public ManagedIdentity()
        {

        }
    }
    /// System and Use Assigned Managed Identity properties
    public partial interface IManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string SystemAssignedManagedIdentitySettingAudience { get; set; }
        /// <summary>Client ID for the user-assigned managed identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client ID for the user-assigned managed identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentitySettingClientId { get; set; }
        /// <summary>
        /// Resource identifier (application ID URI) of the resource, affixed with the .default suffix.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identifier (application ID URI) of the resource, affixed with the .default suffix.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentitySettingScope { get; set; }
        /// <summary>Tenant ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tenant ID.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentitySettingTenantId { get; set; }

    }
    /// System and Use Assigned Managed Identity properties
    internal partial interface IManagedIdentityInternal

    {
        /// <summary>System-assigned managed identity authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationSystemAssignedManagedIdentity SystemAssignedManagedIdentitySetting { get; set; }
        /// <summary>
        /// Audience of the service to authenticate against. Optional; defaults to the audience for Service host configuration.
        /// </summary>
        string SystemAssignedManagedIdentitySettingAudience { get; set; }
        /// <summary>User-assigned managed identity authentication.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationUserAssignedManagedIdentity UserAssignedManagedIdentitySetting { get; set; }
        /// <summary>Client ID for the user-assigned managed identity.</summary>
        string UserAssignedManagedIdentitySettingClientId { get; set; }
        /// <summary>
        /// Resource identifier (application ID URI) of the resource, affixed with the .default suffix.
        /// </summary>
        string UserAssignedManagedIdentitySettingScope { get; set; }
        /// <summary>Tenant ID.</summary>
        string UserAssignedManagedIdentitySettingTenantId { get; set; }

    }
}