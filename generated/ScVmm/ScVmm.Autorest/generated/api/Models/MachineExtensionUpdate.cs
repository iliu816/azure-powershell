// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>Describes a Machine Extension Update.</summary>
    public partial class MachineExtensionUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceUpdate" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceUpdate __resourceUpdate = new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ResourceUpdate();

        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public bool? AutoUpgradeMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).AutoUpgradeMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).AutoUpgradeMinorVersion = value ?? default(bool); }

        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public bool? EnableAutomaticUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).EnableAutomaticUpgrade; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).EnableAutomaticUpgrade = value ?? default(bool); }

        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string ForceUpdateTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).ForceUpdateTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).ForceUpdateTag = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.MachineExtensionUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdateProperties _property;

        /// <summary>Describes Machine Extension Update Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.MachineExtensionUpdateProperties()); set => this._property = value; }

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesProtectedSettings ProtectedSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).ProtectedSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).ProtectedSetting = value ?? null /* model class */; }

        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).Publisher = value ?? null; }

        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesSettings Setting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).Setting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).Setting = value ?? null /* model class */; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceUpdateTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceUpdateInternal)__resourceUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceUpdateInternal)__resourceUpdate).Tag = value ?? null /* model class */; }

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).Type = value ?? null; }

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string TypeHandlerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).TypeHandlerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesInternal)Property).TypeHandlerVersion = value ?? null; }

        /// <summary>Creates an new <see cref="MachineExtensionUpdate" /> instance.</summary>
        public MachineExtensionUpdate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceUpdate), __resourceUpdate);
            await eventListener.AssertObjectIsValid(nameof(__resourceUpdate), __resourceUpdate);
        }
    }
    /// Describes a Machine Extension Update.
    public partial interface IMachineExtensionUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceUpdate
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.",
        SerializedName = @"autoUpgradeMinorVersion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available.",
        SerializedName = @"enableAutomaticUpgrade",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"How the extension handler should be forced to update even if the extension configuration has not changed.",
        SerializedName = @"forceUpdateTag",
        PossibleTypes = new [] { typeof(string) })]
        string ForceUpdateTag { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.",
        SerializedName = @"protectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesProtectedSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesProtectedSettings ProtectedSetting { get; set; }
        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the extension handler publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Json formatted public settings for the extension.",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesSettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesSettings Setting { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the type of the extension; an example is ""CustomScriptExtension"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the script handler.",
        SerializedName = @"typeHandlerVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TypeHandlerVersion { get; set; }

    }
    /// Describes a Machine Extension Update.
    internal partial interface IMachineExtensionUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceUpdateInternal
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available.
        /// </summary>
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        string ForceUpdateTag { get; set; }
        /// <summary>Describes Machine Extension Update Properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdateProperties Property { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesProtectedSettings ProtectedSetting { get; set; }
        /// <summary>The name of the extension handler publisher.</summary>
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionUpdatePropertiesSettings Setting { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        string TypeHandlerVersion { get; set; }

    }
}