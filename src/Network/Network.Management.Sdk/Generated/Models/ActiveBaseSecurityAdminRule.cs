// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Network base admin rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ActiveBaseSecurityAdminRule")]
    public partial class ActiveBaseSecurityAdminRule
    {
        /// <summary>
        /// Initializes a new instance of the ActiveBaseSecurityAdminRule class.
        /// </summary>
        public ActiveBaseSecurityAdminRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveBaseSecurityAdminRule class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="commitTime">Deployment time string.
        /// </param>

        /// <param name="region">Deployment region.
        /// </param>

        /// <param name="configurationDescription">A description of the security admin configuration.
        /// </param>

        /// <param name="ruleCollectionDescription">A description of the rule collection.
        /// </param>

        /// <param name="ruleCollectionAppliesToGroups">Groups for rule collection
        /// </param>

        /// <param name="ruleGroups">Effective configuration groups.
        /// </param>
        public ActiveBaseSecurityAdminRule(string id = default(string), System.DateTime? commitTime = default(System.DateTime?), string region = default(string), string configurationDescription = default(string), string ruleCollectionDescription = default(string), System.Collections.Generic.IList<NetworkManagerSecurityGroupItem> ruleCollectionAppliesToGroups = default(System.Collections.Generic.IList<NetworkManagerSecurityGroupItem>), System.Collections.Generic.IList<ConfigurationGroup> ruleGroups = default(System.Collections.Generic.IList<ConfigurationGroup>))

        {
            this.Id = id;
            this.CommitTime = commitTime;
            this.Region = region;
            this.ConfigurationDescription = configurationDescription;
            this.RuleCollectionDescription = ruleCollectionDescription;
            this.RuleCollectionAppliesToGroups = ruleCollectionAppliesToGroups;
            this.RuleGroups = ruleGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }

        /// <summary>
        /// Gets or sets deployment time string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commitTime")]
        public System.DateTime? CommitTime {get; set; }

        /// <summary>
        /// Gets or sets deployment region.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "region")]
        public string Region {get; set; }

        /// <summary>
        /// Gets or sets a description of the security admin configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "configurationDescription")]
        public string ConfigurationDescription {get; set; }

        /// <summary>
        /// Gets or sets a description of the rule collection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ruleCollectionDescription")]
        public string RuleCollectionDescription {get; set; }

        /// <summary>
        /// Gets or sets groups for rule collection
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ruleCollectionAppliesToGroups")]
        public System.Collections.Generic.IList<NetworkManagerSecurityGroupItem> RuleCollectionAppliesToGroups {get; set; }

        /// <summary>
        /// Gets or sets effective configuration groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ruleGroups")]
        public System.Collections.Generic.IList<ConfigurationGroup> RuleGroups {get; set; }
    }
}