// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Represents the filter actions which are allowed for the transformation
    /// of a message that have been matched by a filter expression.
    /// </summary>
    public partial class RuleAction
    {
        /// <summary>
        /// Initializes a new instance of the RuleAction class.
        /// </summary>
        public RuleAction() { }

        /// <summary>
        /// Initializes a new instance of the RuleAction class.
        /// </summary>
        public RuleAction(bool? requiresPreprocessing = default(bool?), bool? match = default(bool?))
        {
            RequiresPreprocessing = requiresPreprocessing;
            Match = match;
        }

        /// <summary>
        /// Value that indicates whether the rule action requires
        /// preprocessing.
        /// </summary>
        [JsonProperty(PropertyName = "RequiresPreprocessing")]
        public bool? RequiresPreprocessing { get; set; }

        /// <summary>
        /// Matches the BrokeredMessage against the FilterExpression.
        /// </summary>
        [JsonProperty(PropertyName = "Match")]
        public bool? Match { get; set; }

    }
}
