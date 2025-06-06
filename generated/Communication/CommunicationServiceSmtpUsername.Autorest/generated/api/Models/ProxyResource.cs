// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Runtime.Extensions;

    /// <summary>
    /// The resource model definition for a Azure Resource Manager proxy resource. It will not have tags and a location
    /// </summary>
    public partial class ProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IProxyResource,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IProxyResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.Resource();

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Name; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="ProxyResource" /> instance.</summary>
        public ProxyResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The resource model definition for a Azure Resource Manager proxy resource. It will not have tags and a location
    public partial interface IProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResource
    {

    }
    /// The resource model definition for a Azure Resource Manager proxy resource. It will not have tags and a location
    internal partial interface IProxyResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CommunicationServiceSmtpUsername.Models.IResourceInternal
    {

    }
}