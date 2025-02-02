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
    /// A user.
    /// </summary>
    [DataContract(Name = "User")]
    public partial class UserModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserModel" /> class.
        /// </summary>
        /// <param name="id">The ID of the user. root is the root user..</param>
        /// <param name="username">The username of the user..</param>
        /// <param name="type">The type of the user. Will be root, guest, user, or admin..</param>
        /// <param name="token">The authentication token of the user..</param>
        /// <param name="mediaProgress">The user&#39;s media progress..</param>
        /// <param name="seriesHideFromContinueListening">The IDs of series to hide from Continue Series..</param>
        /// <param name="bookmarks">The user&#39;s bookmarks..</param>
        /// <param name="isActive">Whether the user&#39;s account is active..</param>
        /// <param name="isLocked">Whether the user is locked..</param>
        /// <param name="lastSeen">When the user was last seen. Null if never..</param>
        /// <param name="createdAt">When the user was created..</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="librariesAccessible">The libraries accessible to the user. Empty means all..</param>
        /// <param name="itemTagsAccessible">The tags accessible to the user. Empty means all..</param>
        public UserModel(string id = default(string), string username = default(string), string type = default(string), string token = default(string), List<MediaProgressModel> mediaProgress = default(List<MediaProgressModel>), List<string> seriesHideFromContinueListening = default(List<string>), List<AudioBookmarkModel> bookmarks = default(List<AudioBookmarkModel>), bool isActive = default(bool), bool isLocked = default(bool), long? lastSeen = default(long?), long createdAt = default(long), UserPermissionsModel permissions = default(UserPermissionsModel), List<string> librariesAccessible = default(List<string>), List<string> itemTagsAccessible = default(List<string>))
        {
            this.Id = id;
            this.Username = username;
            this.Type = type;
            this.Token = token;
            this.MediaProgress = mediaProgress;
            this.SeriesHideFromContinueListening = seriesHideFromContinueListening;
            this.Bookmarks = bookmarks;
            this.IsActive = isActive;
            this.IsLocked = isLocked;
            this.LastSeen = lastSeen;
            this.CreatedAt = createdAt;
            this.Permissions = permissions;
            this.LibrariesAccessible = librariesAccessible;
            this.ItemTagsAccessible = itemTagsAccessible;
        }

        /// <summary>
        /// The ID of the user. root is the root user.
        /// </summary>
        /// <value>The ID of the user. root is the root user.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The username of the user.
        /// </summary>
        /// <value>The username of the user.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// The type of the user. Will be root, guest, user, or admin.
        /// </summary>
        /// <value>The type of the user. Will be root, guest, user, or admin.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The authentication token of the user.
        /// </summary>
        /// <value>The authentication token of the user.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// The user&#39;s media progress.
        /// </summary>
        /// <value>The user&#39;s media progress.</value>
        [DataMember(Name = "mediaProgress", EmitDefaultValue = false)]
        public List<MediaProgressModel> MediaProgress { get; set; }

        /// <summary>
        /// The IDs of series to hide from Continue Series.
        /// </summary>
        /// <value>The IDs of series to hide from Continue Series.</value>
        [DataMember(Name = "seriesHideFromContinueListening", EmitDefaultValue = false)]
        public List<string> SeriesHideFromContinueListening { get; set; }

        /// <summary>
        /// The user&#39;s bookmarks.
        /// </summary>
        /// <value>The user&#39;s bookmarks.</value>
        [DataMember(Name = "bookmarks", EmitDefaultValue = false)]
        public List<AudioBookmarkModel> Bookmarks { get; set; }

        /// <summary>
        /// Whether the user&#39;s account is active.
        /// </summary>
        /// <value>Whether the user&#39;s account is active.</value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Whether the user is locked.
        /// </summary>
        /// <value>Whether the user is locked.</value>
        [DataMember(Name = "isLocked", EmitDefaultValue = true)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// When the user was last seen. Null if never.
        /// </summary>
        /// <value>When the user was last seen. Null if never.</value>
        [DataMember(Name = "lastSeen", EmitDefaultValue = true)]
        public long? LastSeen { get; set; }

        /// <summary>
        /// When the user was created.
        /// </summary>
        /// <value>When the user was created.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public UserPermissionsModel Permissions { get; set; }

        /// <summary>
        /// The libraries accessible to the user. Empty means all.
        /// </summary>
        /// <value>The libraries accessible to the user. Empty means all.</value>
        [DataMember(Name = "librariesAccessible", EmitDefaultValue = false)]
        public List<string> LibrariesAccessible { get; set; }

        /// <summary>
        /// The tags accessible to the user. Empty means all.
        /// </summary>
        /// <value>The tags accessible to the user. Empty means all.</value>
        [DataMember(Name = "itemTagsAccessible", EmitDefaultValue = false)]
        public List<string> ItemTagsAccessible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  MediaProgress: ").Append(MediaProgress).Append("\n");
            sb.Append("  SeriesHideFromContinueListening: ").Append(SeriesHideFromContinueListening).Append("\n");
            sb.Append("  Bookmarks: ").Append(Bookmarks).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  LibrariesAccessible: ").Append(LibrariesAccessible).Append("\n");
            sb.Append("  ItemTagsAccessible: ").Append(ItemTagsAccessible).Append("\n");
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
