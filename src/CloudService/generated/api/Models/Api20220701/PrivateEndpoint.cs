// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Private endpoint resource.</summary>
    public partial class PrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.Resource();

        /// <summary>
        /// Application security groups in which the private endpoint IP configuration is included.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[] ApplicationSecurityGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).ApplicationSecurityGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).ApplicationSecurityGroup = value ?? null /* arrayOf */; }

        /// <summary>An array of custom dns configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat[] CustomDnsConfig { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).CustomDnsConfig; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).CustomDnsConfig = value ?? null /* arrayOf */; }

        /// <summary>The custom name of the network interface attached to the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string CustomNetworkInterfaceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).CustomNetworkInterfaceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).CustomNetworkInterfaceName = value ?? null; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Backing field for <see cref="ExtendedLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocation _extendedLocation;

        /// <summary>The extended location of the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocation ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ExtendedLocation()); set => this._extendedLocation = value; }

        /// <summary>The name of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string ExtendedLocationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocationInternal)ExtendedLocation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocationInternal)ExtendedLocation).Name = value ?? null; }

        /// <summary>The type of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes? ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocationInternal)ExtendedLocation).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocationInternal)ExtendedLocation).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes)""); }

        /// <summary>
        /// A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration[] IPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).IPConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).IPConfiguration = value ?? null /* arrayOf */; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Id = value ?? null; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access
        /// to approve connections to the remote resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] ManualPrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).ManualPrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).ManualPrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for ExtendedLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocation Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal.ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ExtendedLocation()); set { {_extendedLocation = value;} } }

        /// <summary>Internal Acessors for NetworkInterface</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal.NetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).NetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).NetworkInterface = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointProperties Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateEndpointProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Name; }

        /// <summary>
        /// An array of references to the network interfaces created for this private endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] NetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).NetworkInterface; }

        /// <summary>A grouping of information about the connection to the remote resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] PrivateLinkServiceConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).PrivateLinkServiceConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).PrivateLinkServiceConnection = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointProperties _property;

        /// <summary>Properties of the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.PrivateEndpointProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The ID of the subnet from which the private IP will be allocated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointPropertiesInternal)Property).Subnet = value ?? null /* model class */; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PrivateEndpoint" /> instance.</summary>
        public PrivateEndpoint()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Private endpoint resource.
    public partial interface IPrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResource
    {
        /// <summary>
        /// Application security groups in which the private endpoint IP configuration is included.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application security groups in which the private endpoint IP configuration is included.",
        SerializedName = @"applicationSecurityGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[] ApplicationSecurityGroup { get; set; }
        /// <summary>An array of custom dns configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of custom dns configurations.",
        SerializedName = @"customDnsConfigs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat[] CustomDnsConfig { get; set; }
        /// <summary>The custom name of the network interface attached to the private endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The custom name of the network interface attached to the private endpoint.",
        SerializedName = @"customNetworkInterfaceName",
        PossibleTypes = new [] { typeof(string) })]
        string CustomNetworkInterfaceName { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>The name of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the extended location.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationName { get; set; }
        /// <summary>The type of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the extended location.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes? ExtendedLocationType { get; set; }
        /// <summary>
        /// A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.",
        SerializedName = @"ipConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration[] IPConfiguration { get; set; }
        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access
        /// to approve connections to the remote resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource.",
        SerializedName = @"manualPrivateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] ManualPrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// An array of references to the network interfaces created for this private endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"An array of references to the network interfaces created for this private endpoint.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] NetworkInterface { get;  }
        /// <summary>A grouping of information about the connection to the remote resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A grouping of information about the connection to the remote resource.",
        SerializedName = @"privateLinkServiceConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] PrivateLinkServiceConnection { get; set; }
        /// <summary>The provisioning state of the private endpoint resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the private endpoint resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The ID of the subnet from which the private IP will be allocated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the subnet from which the private IP will be allocated.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet Subnet { get; set; }

    }
    /// Private endpoint resource.
    internal partial interface IPrivateEndpointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal
    {
        /// <summary>
        /// Application security groups in which the private endpoint IP configuration is included.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IApplicationSecurityGroup[] ApplicationSecurityGroup { get; set; }
        /// <summary>An array of custom dns configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ICustomDnsConfigPropertiesFormat[] CustomDnsConfig { get; set; }
        /// <summary>The custom name of the network interface attached to the private endpoint.</summary>
        string CustomNetworkInterfaceName { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>The extended location of the load balancer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IExtendedLocation ExtendedLocation { get; set; }
        /// <summary>The name of the extended location.</summary>
        string ExtendedLocationName { get; set; }
        /// <summary>The type of the extended location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes? ExtendedLocationType { get; set; }
        /// <summary>
        /// A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointIPConfiguration[] IPConfiguration { get; set; }
        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access
        /// to approve connections to the remote resource.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] ManualPrivateLinkServiceConnection { get; set; }
        /// <summary>
        /// An array of references to the network interfaces created for this private endpoint.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterface[] NetworkInterface { get; set; }
        /// <summary>A grouping of information about the connection to the remote resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateLinkServiceConnection[] PrivateLinkServiceConnection { get; set; }
        /// <summary>Properties of the private endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IPrivateEndpointProperties Property { get; set; }
        /// <summary>The provisioning state of the private endpoint resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The ID of the subnet from which the private IP will be allocated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubnet Subnet { get; set; }

    }
}