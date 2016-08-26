// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.HDInsight.Models;

namespace Microsoft.Azure.Management.HDInsight.Models
{
    public partial class ActiveDirectoryConfiguration
    {
        private DirectoryType _directoryType;
        
        /// <summary>
        /// Optional. Gets or sets the directory type.
        /// </summary>
        public DirectoryType DirectoryType
        {
            get { return this._directoryType; }
            set { this._directoryType = value; }
        }
        
        private string _domain;
        
        /// <summary>
        /// Optional. Gets or sets the domain.
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }
        
        private string _domainAdminPassword;
        
        /// <summary>
        /// Optional. Gets or sets the domain admin password.
        /// </summary>
        public string DomainAdminPassword
        {
            get { return this._domainAdminPassword; }
            set { this._domainAdminPassword = value; }
        }
        
        private string _domainAdminUsername;
        
        /// <summary>
        /// Optional. Gets or sets the domain admin user name.
        /// </summary>
        public string DomainAdminUsername
        {
            get { return this._domainAdminUsername; }
            set { this._domainAdminUsername = value; }
        }
        
        private IList<string> _ldapUrls;
        
        /// <summary>
        /// Optional. Gets or sets the LDAP URLs.
        /// </summary>
        public IList<string> LdapUrls
        {
            get { return this._ldapUrls; }
            set { this._ldapUrls = value; }
        }
        
        private string _organizationalUnitDN;
        
        /// <summary>
        /// Optional. Gets or sets the DN for organizational unit.
        /// </summary>
        public string OrganizationalUnitDN
        {
            get { return this._organizationalUnitDN; }
            set { this._organizationalUnitDN = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ActiveDirectoryConfiguration
        /// class.
        /// </summary>
        public ActiveDirectoryConfiguration()
        {
            this.LdapUrls = new LazyList<string>();
        }
    }
}
