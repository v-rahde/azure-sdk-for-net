// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters supplied to the CreateOrUpdate  AuthorizationRules.
    /// </summary>
    [JsonTransformation]
    public partial class SharedAccessAuthorizationRuleCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleCreateOrUpdateParameters class.
        /// </summary>
        public SharedAccessAuthorizationRuleCreateOrUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleCreateOrUpdateParameters class.
        /// </summary>
        public SharedAccessAuthorizationRuleCreateOrUpdateParameters(IList<AccessRights?> rights, string location = default(string), string name = default(string))
        {
            Location = location;
            Name = name;
            Rights = rights;
        }

        /// <summary>
        /// data center location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Name of the AuthorizationRule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rights")]
        public IList<AccessRights?> Rights { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Rights == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rights");
            }
        }
    }
}
