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

namespace Microsoft.Azure.Gallery
{
    public partial class DefinitionTemplates
    {
        private string _defaultDeploymentTemplateId;
        
        /// <summary>
        /// Optional. Gets or sets definition template file ID.
        /// </summary>
        public string DefaultDeploymentTemplateId
        {
            get { return this._defaultDeploymentTemplateId; }
            set { this._defaultDeploymentTemplateId = value; }
        }
        
        private IDictionary<string, string> _deploymentTemplateFileUrls;
        
        /// <summary>
        /// Optional. Gets or sets deployment template file Url.
        /// </summary>
        public IDictionary<string, string> DeploymentTemplateFileUrls
        {
            get { return this._deploymentTemplateFileUrls; }
            set { this._deploymentTemplateFileUrls = value; }
        }
        
        private string _uiDefinitionFileUrl;
        
        /// <summary>
        /// Optional. Gets or sets UI definition file Url.
        /// </summary>
        public string UiDefinitionFileUrl
        {
            get { return this._uiDefinitionFileUrl; }
            set { this._uiDefinitionFileUrl = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionTemplates class.
        /// </summary>
        public DefinitionTemplates()
        {
            this._deploymentTemplateFileUrls = new Dictionary<string, string>();
        }
    }
}