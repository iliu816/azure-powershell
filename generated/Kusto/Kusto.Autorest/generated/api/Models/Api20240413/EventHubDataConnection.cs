// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>Class representing an event hub data connection.</summary>
    public partial class EventHubDataConnection :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubDataConnection,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubDataConnectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection __dataConnection = new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.DataConnection();

        /// <summary>The event hub messages compression type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Compression? Compression { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).Compression; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).Compression = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Compression)""); }

        /// <summary>The event hub consumer group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string ConsumerGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ConsumerGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ConsumerGroup = value ?? null; }

        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventHubDataFormat? DataFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).DataFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).DataFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventHubDataFormat)""); }

        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).DatabaseRouting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).DatabaseRouting = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting)""); }

        /// <summary>The resource ID of the event hub to be used to create a data connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string EventHubResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).EventHubResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).EventHubResourceId = value ?? null; }

        /// <summary>System properties of the event hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] EventSystemProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).EventSystemProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).EventSystemProperty = value ?? null /* arrayOf */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Id; }

        /// <summary>Kind of the endpoint for the data connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DataConnectionKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Kind = value ; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal)__dataConnection).Location = value ?? null; }

        /// <summary>The object ID of the managedIdentityResourceId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string ManagedIdentityObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ManagedIdentityObjectId; }

        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string ManagedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ManagedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ManagedIdentityResourceId = value ?? null; }

        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string MappingRuleName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).MappingRuleName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).MappingRuleName = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Type = value; }

        /// <summary>Internal Acessors for ManagedIdentityObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubDataConnectionInternal.ManagedIdentityObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ManagedIdentityObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ManagedIdentityObjectId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubDataConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.EventHubConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubDataConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionProperties _property;

        /// <summary>The Event Hub data connection properties to validate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.EventHubConnectionProperties()); set => this._property = value; }

        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>
        /// When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only
        /// retrieve events retained by the Event hub, based on its retention period.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public global::System.DateTime? RetrievalStartDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).RetrievalStartDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).RetrievalStartDate = value ?? default(global::System.DateTime); }

        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string TableName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).TableName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionPropertiesInternal)Property).TableName = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api10.IResourceInternal)__dataConnection).Type; }

        /// <summary>Creates an new <see cref="EventHubDataConnection" /> instance.</summary>
        public EventHubDataConnection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dataConnection), __dataConnection);
            await eventListener.AssertObjectIsValid(nameof(__dataConnection), __dataConnection);
        }
    }
    /// Class representing an event hub data connection.
    public partial interface IEventHubDataConnection :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnection
    {
        /// <summary>The event hub messages compression type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The event hub messages compression type",
        SerializedName = @"compression",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Compression) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Compression? Compression { get; set; }
        /// <summary>The event hub consumer group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The event hub consumer group.",
        SerializedName = @"consumerGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumerGroup { get; set; }
        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data format of the message. Optionally the data format can be added to each message.",
        SerializedName = @"dataFormat",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventHubDataFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventHubDataFormat? DataFormat { get; set; }
        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indication for database routing information from the data connection, by default only database routing information is allowed",
        SerializedName = @"databaseRouting",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get; set; }
        /// <summary>The resource ID of the event hub to be used to create a data connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the event hub to be used to create a data connection.",
        SerializedName = @"eventHubResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubResourceId { get; set; }
        /// <summary>System properties of the event hub</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"System properties of the event hub",
        SerializedName = @"eventSystemProperties",
        PossibleTypes = new [] { typeof(string) })]
        string[] EventSystemProperty { get; set; }
        /// <summary>The object ID of the managedIdentityResourceId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The object ID of the managedIdentityResourceId",
        SerializedName = @"managedIdentityObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedIdentityObjectId { get;  }
        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub.",
        SerializedName = @"managedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedIdentityResourceId { get; set; }
        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.",
        SerializedName = @"mappingRuleName",
        PossibleTypes = new [] { typeof(string) })]
        string MappingRuleName { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioned state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only
        /// retrieve events retained by the Event hub, based on its retention period.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only retrieve events retained by the Event hub, based on its retention period.",
        SerializedName = @"retrievalStartDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RetrievalStartDate { get; set; }
        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The table where the data should be ingested. Optionally the table information can be added to each message.",
        SerializedName = @"tableName",
        PossibleTypes = new [] { typeof(string) })]
        string TableName { get; set; }

    }
    /// Class representing an event hub data connection.
    internal partial interface IEventHubDataConnectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDataConnectionInternal
    {
        /// <summary>The event hub messages compression type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Compression? Compression { get; set; }
        /// <summary>The event hub consumer group.</summary>
        string ConsumerGroup { get; set; }
        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventHubDataFormat? DataFormat { get; set; }
        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get; set; }
        /// <summary>The resource ID of the event hub to be used to create a data connection.</summary>
        string EventHubResourceId { get; set; }
        /// <summary>System properties of the event hub</summary>
        string[] EventSystemProperty { get; set; }
        /// <summary>The object ID of the managedIdentityResourceId</summary>
        string ManagedIdentityObjectId { get; set; }
        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub.
        /// </summary>
        string ManagedIdentityResourceId { get; set; }
        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        string MappingRuleName { get; set; }
        /// <summary>The Event Hub data connection properties to validate.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventHubConnectionProperties Property { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only
        /// retrieve events retained by the Event hub, based on its retention period.
        /// </summary>
        global::System.DateTime? RetrievalStartDate { get; set; }
        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        string TableName { get; set; }

    }
}