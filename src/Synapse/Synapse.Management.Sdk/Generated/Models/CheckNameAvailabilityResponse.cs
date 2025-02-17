// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// A response saying whether the workspace name is available
    /// </summary>
    /// <remarks>
    /// A response saying whether the workspace name is available
    /// </remarks>
    public partial class CheckNameAvailabilityResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse class.
        /// </summary>
        public CheckNameAvailabilityResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse class.
        /// </summary>

        /// <param name="message">Validation message
        /// </param>

        /// <param name="available">Whether the workspace name is available
        /// </param>

        /// <param name="reason">Reason the workspace name is or is not available
        /// </param>

        /// <param name="name">Workspace name
        /// </param>
        public CheckNameAvailabilityResponse(string message = default(string), bool? available = default(bool?), string reason = default(string), string name = default(string))

        {
            this.Message = message;
            this.Available = available;
            this.Reason = reason;
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets validation message
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get; set; }

        /// <summary>
        /// Gets or sets whether the workspace name is available
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "available")]
        public bool? Available {get; set; }

        /// <summary>
        /// Gets or sets reason the workspace name is or is not available
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reason")]
        public string Reason {get; set; }

        /// <summary>
        /// Gets or sets workspace name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }
    }
}