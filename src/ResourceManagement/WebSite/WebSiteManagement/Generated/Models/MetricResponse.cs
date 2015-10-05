// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class MetricResponse : Resource
    {
        /// <summary>
        /// Gets or sets the response code.
        /// </summary>
        [JsonProperty(PropertyName = "properties.code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the metrics.
        /// </summary>
        [JsonProperty(PropertyName = "properties.data")]
        public MetricSet Data { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}