// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    public partial class PartnerEventSubscriptionDestinationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerEventSubscriptionDestinationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerEventSubscriptionDestinationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The Azure Resource Id that represents the endpoint of a Partner Destination of an event subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>
        /// Creates an new <see cref="PartnerEventSubscriptionDestinationProperties" /> instance.
        /// </summary>
        public PartnerEventSubscriptionDestinationProperties()
        {

        }
    }
    public partial interface IPartnerEventSubscriptionDestinationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Azure Resource Id that represents the endpoint of a Partner Destination of an event subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure Resource Id that represents the endpoint of a Partner Destination of an event subscription.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }

    }
    internal partial interface IPartnerEventSubscriptionDestinationPropertiesInternal

    {
        /// <summary>
        /// The Azure Resource Id that represents the endpoint of a Partner Destination of an event subscription.
        /// </summary>
        string ResourceId { get; set; }

    }
}