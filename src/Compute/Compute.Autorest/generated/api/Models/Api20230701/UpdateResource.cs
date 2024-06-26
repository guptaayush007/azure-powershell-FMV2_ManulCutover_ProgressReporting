// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>The Update Resource model definition.</summary>
    public partial class UpdateResource :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IUpdateResource,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IUpdateResourceInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IUpdateResourceTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IUpdateResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.UpdateResourceTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="UpdateResource" /> instance.</summary>
        public UpdateResource()
        {

        }
    }
    /// The Update Resource model definition.
    public partial interface IUpdateResource :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IUpdateResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IUpdateResourceTags Tag { get; set; }

    }
    /// The Update Resource model definition.
    internal partial interface IUpdateResourceInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IUpdateResourceTags Tag { get; set; }

    }
}