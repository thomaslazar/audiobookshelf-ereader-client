/*
 * Audiobookshelf API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Audiobookshelf.ClientLibrary.Client.OpenAPIDateConverter;

namespace Audiobookshelf.ClientLibrary.Model
{
    /// <summary>
    /// A notification.
    /// </summary>
    [DataContract(Name = "Notification")]
    public partial class NotificationModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationModel" /> class.
        /// </summary>
        /// <param name="id">The ID of the notification..</param>
        /// <param name="libraryId">The ID of the library the notification is associated with..</param>
        /// <param name="eventName">The name of the event the notification will fire on..</param>
        /// <param name="urls">The Apprise URLs for the notification..</param>
        /// <param name="titleTemplate">The template for the notification title..</param>
        /// <param name="bodyTemplate">The template for the notification body..</param>
        /// <param name="enabled">Whether the notification is enabled..</param>
        /// <param name="type">The notification&#39;s type..</param>
        /// <param name="lastFiredAt">When the notification was last fired..</param>
        /// <param name="lastAttemptFailed">Whether the last attempt failed..</param>
        /// <param name="numConsecutiveFailedAttempts">Number of consecutive failures..</param>
        /// <param name="numTimesFired">Number of times fired..</param>
        /// <param name="createdAt">When the notification was created..</param>
        public NotificationModel(string id = default(string), string libraryId = default(string), string eventName = default(string), List<string> urls = default(List<string>), string titleTemplate = default(string), string bodyTemplate = default(string), bool enabled = default(bool), string type = default(string), long? lastFiredAt = default(long?), bool lastAttemptFailed = default(bool), int numConsecutiveFailedAttempts = default(int), int numTimesFired = default(int), long createdAt = default(long))
        {
            this.Id = id;
            this.LibraryId = libraryId;
            this.EventName = eventName;
            this.Urls = urls;
            this.TitleTemplate = titleTemplate;
            this.BodyTemplate = bodyTemplate;
            this.Enabled = enabled;
            this.Type = type;
            this.LastFiredAt = lastFiredAt;
            this.LastAttemptFailed = lastAttemptFailed;
            this.NumConsecutiveFailedAttempts = numConsecutiveFailedAttempts;
            this.NumTimesFired = numTimesFired;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// The ID of the notification.
        /// </summary>
        /// <value>The ID of the notification.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the library the notification is associated with.
        /// </summary>
        /// <value>The ID of the library the notification is associated with.</value>
        [DataMember(Name = "libraryId", EmitDefaultValue = true)]
        public string LibraryId { get; set; }

        /// <summary>
        /// The name of the event the notification will fire on.
        /// </summary>
        /// <value>The name of the event the notification will fire on.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// The Apprise URLs for the notification.
        /// </summary>
        /// <value>The Apprise URLs for the notification.</value>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// The template for the notification title.
        /// </summary>
        /// <value>The template for the notification title.</value>
        [DataMember(Name = "titleTemplate", EmitDefaultValue = false)]
        public string TitleTemplate { get; set; }

        /// <summary>
        /// The template for the notification body.
        /// </summary>
        /// <value>The template for the notification body.</value>
        [DataMember(Name = "bodyTemplate", EmitDefaultValue = false)]
        public string BodyTemplate { get; set; }

        /// <summary>
        /// Whether the notification is enabled.
        /// </summary>
        /// <value>Whether the notification is enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The notification&#39;s type.
        /// </summary>
        /// <value>The notification&#39;s type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// When the notification was last fired.
        /// </summary>
        /// <value>When the notification was last fired.</value>
        [DataMember(Name = "lastFiredAt", EmitDefaultValue = true)]
        public long? LastFiredAt { get; set; }

        /// <summary>
        /// Whether the last attempt failed.
        /// </summary>
        /// <value>Whether the last attempt failed.</value>
        [DataMember(Name = "lastAttemptFailed", EmitDefaultValue = true)]
        public bool LastAttemptFailed { get; set; }

        /// <summary>
        /// Number of consecutive failures.
        /// </summary>
        /// <value>Number of consecutive failures.</value>
        [DataMember(Name = "numConsecutiveFailedAttempts", EmitDefaultValue = false)]
        public int NumConsecutiveFailedAttempts { get; set; }

        /// <summary>
        /// Number of times fired.
        /// </summary>
        /// <value>Number of times fired.</value>
        [DataMember(Name = "numTimesFired", EmitDefaultValue = false)]
        public int NumTimesFired { get; set; }

        /// <summary>
        /// When the notification was created.
        /// </summary>
        /// <value>When the notification was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  TitleTemplate: ").Append(TitleTemplate).Append("\n");
            sb.Append("  BodyTemplate: ").Append(BodyTemplate).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LastFiredAt: ").Append(LastFiredAt).Append("\n");
            sb.Append("  LastAttemptFailed: ").Append(LastAttemptFailed).Append("\n");
            sb.Append("  NumConsecutiveFailedAttempts: ").Append(NumConsecutiveFailedAttempts).Append("\n");
            sb.Append("  NumTimesFired: ").Append(NumTimesFired).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
