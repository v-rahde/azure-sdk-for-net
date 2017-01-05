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
    /// Represents set of CompositeAction that is performed against a
    /// ServiceBus.Messaging.BrokeredMessage
    /// </summary>
    public partial class CompositeAction
    {
        /// <summary>
        /// Initializes a new instance of the CompositeAction class.
        /// </summary>
        public CompositeAction() { }

        /// <summary>
        /// Initializes a new instance of the CompositeAction class.
        /// </summary>
        public CompositeAction(bool? requiresPreprocessing = default(bool?))
        {
            RequiresPreprocessing = requiresPreprocessing;
        }

        /// <summary>
        /// Value indicating whether the SQL filter expression requires
        /// preprocessing.
        /// </summary>
        [JsonProperty(PropertyName = "RequiresPreprocessing")]
        public bool? RequiresPreprocessing { get; set; }

    }
}
