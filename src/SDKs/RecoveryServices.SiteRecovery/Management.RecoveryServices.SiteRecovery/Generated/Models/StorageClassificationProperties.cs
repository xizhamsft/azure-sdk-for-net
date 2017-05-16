// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage object properties.
    /// </summary>
    public partial class StorageClassificationProperties
    {
        /// <summary>
        /// Initializes a new instance of the StorageClassificationProperties
        /// class.
        /// </summary>
        public StorageClassificationProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageClassificationProperties
        /// class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the Storage
        /// classification.</param>
        public StorageClassificationProperties(string friendlyName = default(string))
        {
            FriendlyName = friendlyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the Storage classification.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

    }
}
