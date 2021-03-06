// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a file on a compute node.
    /// </summary>
    public partial class FileProperties
    {
        /// <summary>
        /// Initializes a new instance of the FileProperties class.
        /// </summary>
        public FileProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileProperties class.
        /// </summary>
        /// <param name="lastModified">The time at which the file was last
        /// modified.</param>
        /// <param name="contentLength">The length of the file.</param>
        /// <param name="creationTime">The file creation time.</param>
        /// <param name="contentType">The content type of the file.</param>
        /// <param name="fileMode">The file mode attribute in octal
        /// format.</param>
        public FileProperties(System.DateTime lastModified, long contentLength, System.DateTime? creationTime = default(System.DateTime?), string contentType = default(string), string fileMode = default(string))
        {
            CreationTime = creationTime;
            LastModified = lastModified;
            ContentLength = contentLength;
            ContentType = contentType;
            FileMode = fileMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the file creation time.
        /// </summary>
        /// <remarks>
        /// The creation time is not returned for files on Linux compute nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the file was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or sets the length of the file.
        /// </summary>
        [JsonProperty(PropertyName = "contentLength")]
        public long ContentLength { get; set; }

        /// <summary>
        /// Gets or sets the content type of the file.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the file mode attribute in octal format.
        /// </summary>
        /// <remarks>
        /// The file mode is returned only for files on Linux compute nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "fileMode")]
        public string FileMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
