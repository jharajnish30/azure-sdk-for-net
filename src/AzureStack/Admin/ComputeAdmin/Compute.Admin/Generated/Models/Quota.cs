// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Holds quota information used to control resource allocation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Quota : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Quota class.
        /// </summary>
        public Quota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Quota class.
        /// </summary>
        /// <param name="id">ID of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of Resource.</param>
        /// <param name="location">Location of the resource.</param>
        /// <param name="availabilitySetCount">Maximum number of availability
        /// sets allowed.</param>
        /// <param name="coresLimit">Maximum number of core allowed.</param>
        /// <param name="virtualMachineCount">Maximum number of virtual
        /// machines allowed.</param>
        /// <param name="vmScaleSetCount">Maximum number of scale sets
        /// allowed.</param>
        public Quota(string id = default(string), string name = default(string), string type = default(string), string location = default(string), int? availabilitySetCount = default(int?), int? coresLimit = default(int?), int? virtualMachineCount = default(int?), int? vmScaleSetCount = default(int?))
            : base(id, name, type, location)
        {
            AvailabilitySetCount = availabilitySetCount;
            CoresLimit = coresLimit;
            VirtualMachineCount = virtualMachineCount;
            VmScaleSetCount = vmScaleSetCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets maximum number of availability sets allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilitySetCount")]
        public int? AvailabilitySetCount { get; set; }

        /// <summary>
        /// Gets or sets maximum number of core allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.coresLimit")]
        public int? CoresLimit { get; set; }

        /// <summary>
        /// Gets or sets maximum number of virtual machines allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineCount")]
        public int? VirtualMachineCount { get; set; }

        /// <summary>
        /// Gets or sets maximum number of scale sets allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmScaleSetCount")]
        public int? VmScaleSetCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AvailabilitySetCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AvailabilitySetCount", 0);
            }
            if (CoresLimit < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "CoresLimit", 0);
            }
            if (VirtualMachineCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "VirtualMachineCount", 0);
            }
            if (VmScaleSetCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "VmScaleSetCount", 0);
            }
        }
    }
}