// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Entity tag is used for comparing two or more entities from the same
    /// requested resource.
    /// </summary>
    public partial class ETag
    {
        /// <summary>
        /// Initializes a new instance of the ETag class.
        /// </summary>
        public ETag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ETag class.
        /// </summary>
        /// <param name="etag">Entity tag is used for comparing two or more
        /// entities from the same requested resource.</param>
        public ETag(string etag = default(string))
        {
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets entity tag is used for comparing two or more entities
        /// from the same requested resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}