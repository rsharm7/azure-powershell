// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.PowerShell;

    /// <summary>Network related settings</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkConnectionTypeConverter))]
    public partial class NetworkConnection
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.NetworkConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnection" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnection DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NetworkConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.NetworkConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnection" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnection DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NetworkConnection(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NetworkConnection" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NetworkConnection" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnection FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.NetworkConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NetworkConnection(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.NetworkPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("DomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainName, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).OrganizationUnit = (string) content.GetValueForProperty("OrganizationUnit",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).OrganizationUnit, global::System.Convert.ToString);
            }
            if (content.Contains("DomainUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainUsername = (string) content.GetValueForProperty("DomainUsername",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainUsername, global::System.Convert.ToString);
            }
            if (content.Contains("DomainPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainPassword = (string) content.GetValueForProperty("DomainPassword",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainPassword, global::System.Convert.ToString);
            }
            if (content.Contains("HealthCheckStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).HealthCheckStatus = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthCheckStatus?) content.GetValueForProperty("HealthCheckStatus",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).HealthCheckStatus, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthCheckStatus.CreateFrom);
            }
            if (content.Contains("NetworkingResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).NetworkingResourceGroupName = (string) content.GetValueForProperty("NetworkingResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).NetworkingResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("DomainJoinType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainJoinType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DomainJoinType) content.GetValueForProperty("DomainJoinType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainJoinType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DomainJoinType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.NetworkConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NetworkConnection(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.NetworkPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api30.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("DomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainName, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).OrganizationUnit = (string) content.GetValueForProperty("OrganizationUnit",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).OrganizationUnit, global::System.Convert.ToString);
            }
            if (content.Contains("DomainUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainUsername = (string) content.GetValueForProperty("DomainUsername",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainUsername, global::System.Convert.ToString);
            }
            if (content.Contains("DomainPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainPassword = (string) content.GetValueForProperty("DomainPassword",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainPassword, global::System.Convert.ToString);
            }
            if (content.Contains("HealthCheckStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).HealthCheckStatus = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthCheckStatus?) content.GetValueForProperty("HealthCheckStatus",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).HealthCheckStatus, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.HealthCheckStatus.CreateFrom);
            }
            if (content.Contains("NetworkingResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).NetworkingResourceGroupName = (string) content.GetValueForProperty("NetworkingResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).NetworkingResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("DomainJoinType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainJoinType = (Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DomainJoinType) content.GetValueForProperty("DomainJoinType",((Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.INetworkConnectionInternal)this).DomainJoinType, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.DomainJoinType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Network related settings
    [System.ComponentModel.TypeConverter(typeof(NetworkConnectionTypeConverter))]
    public partial interface INetworkConnection

    {

    }
}