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
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    /// <summary>
    /// The definition of a get resource storage config response.
    /// </summary>
    public partial class GetResourceStorageConfigResponse : AzureOperationResponse
    {
        private string _eTags;
        
        /// <summary>
        /// Optional. ETag of the Vault.
        /// </summary>
        public string ETags
        {
            get { return this._eTags; }
            set { this._eTags = value; }
        }
        
        private long _id;
        
        /// <summary>
        /// Optional. Gets or sets the resource ID.
        /// </summary>
        public long Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private long _name;
        
        /// <summary>
        /// Optional. Gets or sets the resource Name.
        /// </summary>
        public long Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private StorageDetails _storageDetails;
        
        /// <summary>
        /// Optional. The resource storage details.
        /// </summary>
        public StorageDetails StorageDetails
        {
            get { return this._storageDetails; }
            set { this._storageDetails = value; }
        }
        
        private long _type;
        
        /// <summary>
        /// Optional. Gets or sets the resource Type.
        /// </summary>
        public long Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GetResourceStorageConfigResponse
        /// class.
        /// </summary>
        public GetResourceStorageConfigResponse()
        {
        }
    }
}
