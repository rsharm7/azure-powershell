// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Result of the request to list origins. It contains a list of origin objects and a URL link to get the next set of results.
    /// </summary>
    public partial class OriginListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginListResultInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOrigin[] Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOriginListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of origin objects if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOrigin[] _value;

        /// <summary>List of CDN origins within an endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOrigin[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OriginListResult" /> instance.</summary>
        public OriginListResult()
        {

        }
    }
    /// Result of the request to list origins. It contains a list of origin objects and a URL link to get the next set of results.
    public partial interface IOriginListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of origin objects if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL to get the next set of origin objects if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of CDN origins within an endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of CDN origins within an endpoint",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOrigin) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOrigin[] Value { get;  }

    }
    /// Result of the request to list origins. It contains a list of origin objects and a URL link to get the next set of results.
    internal partial interface IOriginListResultInternal

    {
        /// <summary>URL to get the next set of origin objects if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>List of CDN origins within an endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IOrigin[] Value { get; set; }

    }
}