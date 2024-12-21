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
    /// A user with session info.
    /// </summary>
    [DataContract(Name = "UserWithSession")]
    public partial class UserWithSessionModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithSessionModel" /> class.
        /// </summary>
        /// <param name="id">The ID of the user..</param>
        /// <param name="username">The username of the user..</param>
        /// <param name="type">The type of the user..</param>
        /// <param name="session">session.</param>
        /// <param name="lastSeen">When the user was last seen..</param>
        /// <param name="createdAt">When the user was created..</param>
        public UserWithSessionModel(string id = default(string), string username = default(string), string type = default(string), PlaybackSessionExpandedModel session = default(PlaybackSessionExpandedModel), long? lastSeen = default(long?), long createdAt = default(long))
        {
            this.Id = id;
            this.Username = username;
            this.Type = type;
            this.Session = session;
            this.LastSeen = lastSeen;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        /// <value>The ID of the user.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The username of the user.
        /// </summary>
        /// <value>The username of the user.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// The type of the user.
        /// </summary>
        /// <value>The type of the user.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = true)]
        public PlaybackSessionExpandedModel Session { get; set; }

        /// <summary>
        /// When the user was last seen.
        /// </summary>
        /// <value>When the user was last seen.</value>
        [DataMember(Name = "lastSeen", EmitDefaultValue = true)]
        public long? LastSeen { get; set; }

        /// <summary>
        /// When the user was created.
        /// </summary>
        /// <value>When the user was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserWithSessionModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
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