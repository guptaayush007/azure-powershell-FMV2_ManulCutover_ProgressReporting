// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Storage mapping input.
    /// </summary>
    public partial class StorageClassificationMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the StorageClassificationMappingInput class.
        /// </summary>
        public StorageClassificationMappingInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageClassificationMappingInput class.
        /// </summary>

        /// <param name="properties">Storage mapping input properties.
        /// </param>
        public StorageClassificationMappingInput(StorageMappingInputProperties properties = default(StorageMappingInputProperties))

        {
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets storage mapping input properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public StorageMappingInputProperties Properties {get; set; }
    }
}