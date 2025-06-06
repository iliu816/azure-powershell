// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>Network Interface model</summary>
    public partial class NetworkInterface :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.INetworkInterface,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.INetworkInterfaceInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>
        /// Gets the display name of the network interface as shown in the vmmServer. This is the fallback label for a NIC when the
        /// name is not set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="Ipv4Address" /> property.</summary>
        private System.Collections.Generic.List<string> _ipv4Address;

        /// <summary>Gets the nic ipv4 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Ipv4Address { get => this._ipv4Address; }

        /// <summary>Backing field for <see cref="Ipv4AddressType" /> property.</summary>
        private string _ipv4AddressType;

        /// <summary>Gets or sets the ipv4 address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string Ipv4AddressType { get => this._ipv4AddressType; set => this._ipv4AddressType = value; }

        /// <summary>Backing field for <see cref="Ipv6Address" /> property.</summary>
        private System.Collections.Generic.List<string> _ipv6Address;

        /// <summary>Gets the nic ipv6 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Ipv6Address { get => this._ipv6Address; }

        /// <summary>Backing field for <see cref="Ipv6AddressType" /> property.</summary>
        private string _ipv6AddressType;

        /// <summary>Gets or sets the ipv6 address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string Ipv6AddressType { get => this._ipv6AddressType; set => this._ipv6AddressType = value; }

        /// <summary>Backing field for <see cref="MacAddress" /> property.</summary>
        private string _macAddress;

        /// <summary>Gets or sets the nic MAC address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string MacAddress { get => this._macAddress; set => this._macAddress = value; }

        /// <summary>Backing field for <see cref="MacAddressType" /> property.</summary>
        private string _macAddressType;

        /// <summary>Gets or sets the mac address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string MacAddressType { get => this._macAddressType; set => this._macAddressType = value; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.INetworkInterfaceInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for Ipv4Address</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.INetworkInterfaceInternal.Ipv4Address { get => this._ipv4Address; set { {_ipv4Address = value;} } }

        /// <summary>Internal Acessors for Ipv6Address</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.INetworkInterfaceInternal.Ipv6Address { get => this._ipv6Address; set { {_ipv6Address = value;} } }

        /// <summary>Internal Acessors for NetworkName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.INetworkInterfaceInternal.NetworkName { get => this._networkName; set { {_networkName = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Gets or sets the name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        /// <summary>Gets the name of the virtual network in vmmServer that the nic is connected to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; }

        /// <summary>Backing field for <see cref="NicId" /> property.</summary>
        private string _nicId;

        /// <summary>Gets or sets the nic id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string NicId { get => this._nicId; set => this._nicId = value; }

        /// <summary>Backing field for <see cref="VirtualNetworkId" /> property.</summary>
        private string _virtualNetworkId;

        /// <summary>
        /// Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string VirtualNetworkId { get => this._virtualNetworkId; set => this._virtualNetworkId = value; }

        /// <summary>Creates an new <see cref="NetworkInterface" /> instance.</summary>
        public NetworkInterface()
        {

        }
    }
    /// Network Interface model
    public partial interface INetworkInterface :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets the display name of the network interface as shown in the vmmServer. This is the fallback label for a NIC when the
        /// name is not set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the display name of the network interface as shown in the vmmServer. This is the fallback label for a NIC when the name is not set.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Gets the nic ipv4 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the nic ipv4 addresses.",
        SerializedName = @"ipv4Addresses",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Ipv4Address { get;  }
        /// <summary>Gets or sets the ipv4 address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the ipv4 address type.",
        SerializedName = @"ipv4AddressType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string Ipv4AddressType { get; set; }
        /// <summary>Gets the nic ipv6 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the nic ipv6 addresses.",
        SerializedName = @"ipv6Addresses",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Ipv6Address { get;  }
        /// <summary>Gets or sets the ipv6 address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the ipv6 address type.",
        SerializedName = @"ipv6AddressType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string Ipv6AddressType { get; set; }
        /// <summary>Gets or sets the nic MAC address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the nic MAC address.",
        SerializedName = @"macAddress",
        PossibleTypes = new [] { typeof(string) })]
        string MacAddress { get; set; }
        /// <summary>Gets or sets the mac address type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the mac address type.",
        SerializedName = @"macAddressType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string MacAddressType { get; set; }
        /// <summary>Gets or sets the name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the name of the network interface.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Gets the name of the virtual network in vmmServer that the nic is connected to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the name of the virtual network in vmmServer that the nic is connected to.",
        SerializedName = @"networkName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get;  }
        /// <summary>Gets or sets the nic id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the nic id.",
        SerializedName = @"nicId",
        PossibleTypes = new [] { typeof(string) })]
        string NicId { get; set; }
        /// <summary>
        /// Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic.",
        SerializedName = @"virtualNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualNetworkId { get; set; }

    }
    /// Network Interface model
    internal partial interface INetworkInterfaceInternal

    {
        /// <summary>
        /// Gets the display name of the network interface as shown in the vmmServer. This is the fallback label for a NIC when the
        /// name is not set.
        /// </summary>
        string DisplayName { get; set; }
        /// <summary>Gets the nic ipv4 addresses.</summary>
        System.Collections.Generic.List<string> Ipv4Address { get; set; }
        /// <summary>Gets or sets the ipv4 address type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string Ipv4AddressType { get; set; }
        /// <summary>Gets the nic ipv6 addresses.</summary>
        System.Collections.Generic.List<string> Ipv6Address { get; set; }
        /// <summary>Gets or sets the ipv6 address type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string Ipv6AddressType { get; set; }
        /// <summary>Gets or sets the nic MAC address.</summary>
        string MacAddress { get; set; }
        /// <summary>Gets or sets the mac address type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Dynamic", "Static")]
        string MacAddressType { get; set; }
        /// <summary>Gets or sets the name of the network interface.</summary>
        string Name { get; set; }
        /// <summary>Gets the name of the virtual network in vmmServer that the nic is connected to.</summary>
        string NetworkName { get; set; }
        /// <summary>Gets or sets the nic id.</summary>
        string NicId { get; set; }
        /// <summary>
        /// Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic.
        /// </summary>
        string VirtualNetworkId { get; set; }

    }
}