// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Upstream auth settings. If not set, no auth is used for upstream messages.</summary>
    public partial class UpstreamAuthSettings :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IUpstreamAuthSettings,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IUpstreamAuthSettingsInternal
    {

        /// <summary>Backing field for <see cref="ManagedIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettings _managedIdentity;

        /// <summary>Managed identity settings for upstream.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettings ManagedIdentity { get => (this._managedIdentity = this._managedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ManagedIdentitySettings()); set => this._managedIdentity = value; }

        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Inlined)]
        public string ManagedIdentityResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettingsInternal)ManagedIdentity).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettingsInternal)ManagedIdentity).Resource = value ?? null; }

        /// <summary>Internal Acessors for ManagedIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettings Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IUpstreamAuthSettingsInternal.ManagedIdentity { get => (this._managedIdentity = this._managedIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.ManagedIdentitySettings()); set { {_managedIdentity = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.UpstreamAuthType? _type;

        /// <summary>Upstream auth type enum.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.UpstreamAuthType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="UpstreamAuthSettings" /> instance.</summary>
        public UpstreamAuthSettings()
        {

        }
    }
    /// Upstream auth settings. If not set, no auth is used for upstream messages.
    public partial interface IUpstreamAuthSettings :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Resource indicating the App ID URI of the target resource.
        It also appears in the aud (audience) claim of the issued token.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedIdentityResource { get; set; }
        /// <summary>Upstream auth type enum.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Upstream auth type enum.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.UpstreamAuthType) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.UpstreamAuthType? Type { get; set; }

    }
    /// Upstream auth settings. If not set, no auth is used for upstream messages.
    internal partial interface IUpstreamAuthSettingsInternal

    {
        /// <summary>Managed identity settings for upstream.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.IManagedIdentitySettings ManagedIdentity { get; set; }
        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        string ManagedIdentityResource { get; set; }
        /// <summary>Upstream auth type enum.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Support.UpstreamAuthType? Type { get; set; }

    }
}