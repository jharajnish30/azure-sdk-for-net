// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role Definitions filter
    /// </summary>
    public partial class RoleDefinitionFilterInner
    {
        /// <summary>
        /// Initializes a new instance of the RoleDefinitionFilterInner class.
        /// </summary>
        public RoleDefinitionFilterInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleDefinitionFilterInner class.
        /// </summary>
        /// <param name="roleName">Returns role definition with the specific
        /// name.</param>
        public RoleDefinitionFilterInner(string roleName = default(string))
        {
            RoleName = roleName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets returns role definition with the specific name.
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

    }
}