// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The CRM connector entities.
    /// </summary>
    public partial class CrmConnectorEntities
    {
        /// <summary>
        /// Initializes a new instance of the CrmConnectorEntities class.
        /// </summary>
        public CrmConnectorEntities() { }

        /// <summary>
        /// Initializes a new instance of the CrmConnectorEntities class.
        /// </summary>
        /// <param name="logicalName">The logical name.</param>
        /// <param name="displayName">The display name.</param>
        /// <param name="isProfile">Indicating whether this is profile.</param>
        public CrmConnectorEntities(string logicalName, string displayName = default(string), bool? isProfile = default(bool?))
        {
            LogicalName = logicalName;
            DisplayName = displayName;
            IsProfile = isProfile;
        }

        /// <summary>
        /// Gets or sets the logical name.
        /// </summary>
        [JsonProperty(PropertyName = "logicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets indicating whether this is profile.
        /// </summary>
        [JsonProperty(PropertyName = "isProfile")]
        public bool? IsProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LogicalName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LogicalName");
            }
        }
    }
}
