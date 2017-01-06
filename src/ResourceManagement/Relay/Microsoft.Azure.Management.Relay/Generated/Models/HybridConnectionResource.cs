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
    /// Description of HybridConnection Resource.
    /// </summary>
    [JsonTransformation]
    public partial class HybridConnectionResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the HybridConnectionResource class.
        /// </summary>
        public HybridConnectionResource() { }

        /// <summary>
        /// Initializes a new instance of the HybridConnectionResource class.
        /// </summary>
        public HybridConnectionResource(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string path = default(string), Relaytype? relayType = default(Relaytype?), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), int? listenerCount = default(int?), bool? requiresClientAuthorization = default(bool?), AuthorizationRules authorizationRules = default(AuthorizationRules), bool? requiresTransportSecurity = default(bool?), bool? isDynamic = default(bool?), string userMetadata = default(string), string collectionName = default(string))
            : base(location, id, name, type, tags)
        {
            Path = path;
            RelayType = relayType;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ListenerCount = listenerCount;
            RequiresClientAuthorization = requiresClientAuthorization;
            AuthorizationRules = authorizationRules;
            RequiresTransportSecurity = requiresTransportSecurity;
            IsDynamic = isDynamic;
            UserMetadata = userMetadata;
            CollectionName = collectionName;
        }

        /// <summary>
        /// The path of the relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Path")]
        public string Path { get; set; }

        /// <summary>
        /// Relay Type. Possible values include: 'NetTcp', 'Http'
        /// </summary>
        [JsonProperty(PropertyName = "properties.RelayType")]
        public Relaytype? RelayType { get; set; }

        /// <summary>
        /// The time the namespace was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time the namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The number of listeners for this relay
        /// </summary>
        [JsonProperty(PropertyName = "properties.ListenerCount")]
        public int? ListenerCount { get; set; }

        /// <summary>
        /// true if client authorization is needed for this relay; otherwise,
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.RequiresClientAuthorization")]
        public bool? RequiresClientAuthorization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.AuthorizationRules")]
        public AuthorizationRules AuthorizationRules { get; set; }

        /// <summary>
        /// true if transport security is needed for this relay; otherwise,
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.RequiresTransportSecurity")]
        public bool? RequiresTransportSecurity { get; set; }

        /// <summary>
        /// true if the relay is dynamic; otherwise, false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.IsDynamic")]
        public bool? IsDynamic { get; set; }

        /// <summary>
        /// TheThe user metadata associated with this instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.UserMetadata")]
        public string UserMetadata { get; set; }

        /// <summary>
        /// The name of the collection associated with the relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.CollectionName")]
        public string CollectionName { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
