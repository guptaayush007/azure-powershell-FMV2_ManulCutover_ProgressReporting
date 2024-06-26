// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>The properties of client group.</summary>
    public partial class ClientGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description for the Client Group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientGroupPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the ClientGroup resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Query" /> property.</summary>
        private string _query;

        /// <summary>
        /// The grouping query for the clients.
        /// Example : attributes.keyName IN ['a', 'b', 'c'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Query { get => this._query; set => this._query = value; }

        /// <summary>Creates an new <see cref="ClientGroupProperties" /> instance.</summary>
        public ClientGroupProperties()
        {

        }
    }
    /// The properties of client group.
    public partial interface IClientGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>Description for the Client Group resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description for the Client Group resource.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Provisioning state of the ClientGroup resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the ClientGroup resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed", "Deleted")]
        string ProvisioningState { get;  }
        /// <summary>
        /// The grouping query for the clients.
        /// Example : attributes.keyName IN ['a', 'b', 'c'].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The grouping query for the clients.
        Example : attributes.keyName IN ['a', 'b', 'c'].",
        SerializedName = @"query",
        PossibleTypes = new [] { typeof(string) })]
        string Query { get; set; }

    }
    /// The properties of client group.
    internal partial interface IClientGroupPropertiesInternal

    {
        /// <summary>Description for the Client Group resource.</summary>
        string Description { get; set; }
        /// <summary>Provisioning state of the ClientGroup resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed", "Deleted")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// The grouping query for the clients.
        /// Example : attributes.keyName IN ['a', 'b', 'c'].
        /// </summary>
        string Query { get; set; }

    }
}