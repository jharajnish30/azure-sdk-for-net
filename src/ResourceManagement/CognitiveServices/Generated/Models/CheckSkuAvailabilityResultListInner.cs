// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CognitiveServices;
    using Microsoft.Azure.Management.CognitiveServices.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Check SKU availability result list.
    /// </summary>
    public partial class CheckSkuAvailabilityResultListInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckSkuAvailabilityResultListInner class.
        /// </summary>
        public CheckSkuAvailabilityResultListInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckSkuAvailabilityResultListInner class.
        /// </summary>
        /// <param name="value">Check SKU availability result list.</param>
        public CheckSkuAvailabilityResultListInner(IList<CheckSkuAvailabilityResult> value = default(IList<CheckSkuAvailabilityResult>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets check SKU availability result list.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<CheckSkuAvailabilityResult> Value { get; set; }

    }
}