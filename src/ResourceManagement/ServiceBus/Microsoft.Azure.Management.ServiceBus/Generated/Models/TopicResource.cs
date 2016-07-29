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
    /// Description of topic Resource.
    /// </summary>
    [JsonTransformation]
    public partial class TopicResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TopicResource class.
        /// </summary>
        public TopicResource() { }

        /// <summary>
        /// Initializes a new instance of the TopicResource class.
        /// </summary>
        public TopicResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DateTime? accessedAt = default(DateTime?), TimeSpan? autoDeleteOnIdle = default(TimeSpan?), AvailabilityStatus? availabilityStatus = default(AvailabilityStatus?), DateTime? createdAt = default(DateTime?), TimeSpan? defaultMessageTimeToLive = default(TimeSpan?), TimeSpan? duplicateDetectionHistoryTimeWindow = default(TimeSpan?), bool? enableBatchedOperations = default(bool?), bool? enableExpress = default(bool?), bool? enableFilteringMessagesBeforePublishing = default(bool?), bool? enablePartitioning = default(bool?), bool? isAnonymousAccessible = default(bool?), long? maxSizeInMegabytes = default(long?), MessageCountDetails messageCountDetails = default(MessageCountDetails), string path = default(string), bool? requiresDuplicateDetection = default(bool?), long? sizeInBytes = default(long?), EntityStatus? status = default(EntityStatus?), int? subscriptionCount = default(int?), bool? supportOrdering = default(bool?), DateTime? updatedAt = default(DateTime?), string userMetadata = default(string))
            : base(id, name, type, location, tags)
        {
            AccessedAt = accessedAt;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            AvailabilityStatus = availabilityStatus;
            CreatedAt = createdAt;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            EnableBatchedOperations = enableBatchedOperations;
            EnableExpress = enableExpress;
            EnableFilteringMessagesBeforePublishing = enableFilteringMessagesBeforePublishing;
            EnablePartitioning = enablePartitioning;
            IsAnonymousAccessible = isAnonymousAccessible;
            MaxSizeInMegabytes = maxSizeInMegabytes;
            MessageCountDetails = messageCountDetails;
            Path = path;
            RequiresDuplicateDetection = requiresDuplicateDetection;
            SizeInBytes = sizeInBytes;
            Status = status;
            SubscriptionCount = subscriptionCount;
            SupportOrdering = supportOrdering;
            UpdatedAt = updatedAt;
            UserMetadata = userMetadata;
        }

        /// <summary>
        /// Last time the message was sent or a request was received for this
        /// topic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.AccessedAt")]
        public DateTime? AccessedAt { get; set; }

        /// <summary>
        /// TimeSpan idle interval after which the topic is automatically
        /// deleted. The minimum duration is 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.AutoDeleteOnIdle")]
        public TimeSpan? AutoDeleteOnIdle { get; set; }

        /// <summary>
        /// Entity availability status for the topic. Possible values include:
        /// 'Available', 'Limited', 'Renaming', 'Restoring', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.AvailabilityStatus ")]
        public AvailabilityStatus? AvailabilityStatus { get; set; }

        /// <summary>
        /// Exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Default message time to live value. This is the duration after
        /// which the message expires, starting from when the message is sent
        /// to Service Bus. This is the default value used when TimeToLive is
        /// not set on a message itself.
        /// </summary>
        [JsonProperty(PropertyName = "properties.DefaultMessageTimeToLive")]
        public TimeSpan? DefaultMessageTimeToLive { get; set; }

        /// <summary>
        /// TimeSpan structure that defines the duration of the duplicate
        /// detection history. The default value is 10 minutes..
        /// </summary>
        [JsonProperty(PropertyName = "properties.DuplicateDetectionHistoryTimeWindow ")]
        public TimeSpan? DuplicateDetectionHistoryTimeWindow { get; set; }

        /// <summary>
        /// Value that indicates whether server-side batched operations are
        /// enabled..
        /// </summary>
        [JsonProperty(PropertyName = "properties.EnableBatchedOperations")]
        public bool? EnableBatchedOperations { get; set; }

        /// <summary>
        /// Value that indicates whether Express Entities are enabled. An
        /// express topic holds a message in memory temporarily before
        /// writing it to persistent storage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.EnableExpress")]
        public bool? EnableExpress { get; set; }

        /// <summary>
        /// Whether messages should be filtered before publishing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.EnableFilteringMessagesBeforePublishing")]
        public bool? EnableFilteringMessagesBeforePublishing { get; set; }

        /// <summary>
        /// Value that indicates whether the topic to be partitioned across
        /// multiple message brokers is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.EnablePartitioning")]
        public bool? EnablePartitioning { get; set; }

        /// <summary>
        /// Value that indicates whether the message is anonymous accessible.
        /// </summary>
        [JsonProperty(PropertyName = "properties.IsAnonymousAccessible")]
        public bool? IsAnonymousAccessible { get; set; }

        /// <summary>
        /// Maximum size of the topic in megabytes, which is the size of
        /// memory allocated for the topic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.MaxSizeInMegabytes ")]
        public long? MaxSizeInMegabytes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.MessageCountDetails")]
        public MessageCountDetails MessageCountDetails { get; set; }

        /// <summary>
        /// Name of the topic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.Path")]
        public string Path { get; set; }

        /// <summary>
        /// Value indicating if this topic requires duplicate detection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.RequiresDuplicateDetection")]
        public bool? RequiresDuplicateDetection { get; set; }

        /// <summary>
        /// Size of the topic in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.SizeInBytes ")]
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Enumerates the possible values for the status of a messaging
        /// entity. Possible values include: 'Active', 'Creating',
        /// 'Deleting', 'Disabled', 'ReceiveDisabled', 'Renaming',
        /// 'Restoring', 'SendDisabled', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.Status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// Number of subscriptions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.SubscriptionCount")]
        public int? SubscriptionCount { get; set; }

        /// <summary>
        /// Value that indicates whether the topic supports ordering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.SupportOrdering")]
        public bool? SupportOrdering { get; set; }

        /// <summary>
        /// The exact time the message has been updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Represents the metadata description of the topic
        /// </summary>
        [JsonProperty(PropertyName = "properties.UserMetadata")]
        public string UserMetadata { get; set; }

    }
}
