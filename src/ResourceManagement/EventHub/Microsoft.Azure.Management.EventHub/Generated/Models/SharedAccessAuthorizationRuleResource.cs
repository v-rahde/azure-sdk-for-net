// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of a Namespace AuthorizationRules.
    /// </summary>
    [JsonTransformation]
    public partial class SharedAccessAuthorizationRuleResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        public SharedAccessAuthorizationRuleResource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        public SharedAccessAuthorizationRuleResource(string location, IList<AccessRights?> rights, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(location, id, name, type, tags)
        {
            Rights = rights;
        }

        /// <summary>
        /// The rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rights")]
        public IList<AccessRights?> Rights { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (Rights == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rights");
            }
        }
    }
}
