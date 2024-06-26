// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Describes properties of a task.
    /// </summary>
    public partial class SecurityTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the SecurityTaskProperties class.
        /// </summary>
        public SecurityTaskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityTaskProperties class.
        /// </summary>

        /// <param name="state">State of the task (Active, Resolved etc.)
        /// </param>

        /// <param name="creationTimeUtc">The time this task was discovered in UTC
        /// </param>

        /// <param name="securityTaskParameters">Changing set of properties, depending on the task type that is derived from
        /// the name field
        /// </param>

        /// <param name="lastStateChangeTimeUtc">The time this task&#39;s details were last changed in UTC
        /// </param>

        /// <param name="subState">Additional data on the state of the task
        /// </param>
        public SecurityTaskProperties(string state = default(string), System.DateTime? creationTimeUtc = default(System.DateTime?), SecurityTaskParameters securityTaskParameters = default(SecurityTaskParameters), System.DateTime? lastStateChangeTimeUtc = default(System.DateTime?), string subState = default(string))

        {
            this.State = state;
            this.CreationTimeUtc = creationTimeUtc;
            this.SecurityTaskParameters = securityTaskParameters;
            this.LastStateChangeTimeUtc = lastStateChangeTimeUtc;
            this.SubState = subState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets state of the task (Active, Resolved etc.)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public string State {get; private set; }

        /// <summary>
        /// Gets the time this task was discovered in UTC
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "creationTimeUtc")]
        public System.DateTime? CreationTimeUtc {get; private set; }

        /// <summary>
        /// Gets or sets changing set of properties, depending on the task type that is
        /// derived from the name field
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "securityTaskParameters")]
        public SecurityTaskParameters SecurityTaskParameters {get; set; }

        /// <summary>
        /// Gets the time this task&#39;s details were last changed in UTC
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastStateChangeTimeUtc")]
        public System.DateTime? LastStateChangeTimeUtc {get; private set; }

        /// <summary>
        /// Gets additional data on the state of the task
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subState")]
        public string SubState {get; private set; }
    }
}