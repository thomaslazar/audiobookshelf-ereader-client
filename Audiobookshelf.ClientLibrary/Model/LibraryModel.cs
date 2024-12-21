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
    /// A library.
    /// </summary>
    [DataContract(Name = "Library")]
    public partial class LibraryModel : IValidatableObject
    {
        /// <summary>
        /// The type of media that the library contains. Will be book or podcast. (Read Only)
        /// </summary>
        /// <value>The type of media that the library contains. Will be book or podcast. (Read Only)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Enum Book for value: book
            /// </summary>
            [EnumMember(Value = "book")]
            Book = 1,

            /// <summary>
            /// Enum Podcast for value: podcast
            /// </summary>
            [EnumMember(Value = "podcast")]
            Podcast = 2
        }


        /// <summary>
        /// The type of media that the library contains. Will be book or podcast. (Read Only)
        /// </summary>
        /// <value>The type of media that the library contains. Will be book or podcast. (Read Only)</value>
        [DataMember(Name = "mediaType", EmitDefaultValue = false)]
        public MediaTypeEnum? MediaType { get; set; }

        /// <summary>
        /// Returns false as MediaType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMediaType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryModel" /> class.
        /// </summary>
        /// <param name="name">The name of the library..</param>
        /// <param name="folders">The folders that the library is composed of on the server..</param>
        /// <param name="displayOrder">Display position of the library in the list of libraries. Must be &gt;&#x3D; 1..</param>
        /// <param name="icon">The selected icon for the library. See Library Icons for a list of possible icons..</param>
        /// <param name="provider">Preferred metadata provider for the library. See Metadata Providers for a list of possible providers..</param>
        /// <param name="settings">settings.</param>
        public LibraryModel(string name = default(string), List<FolderModel> folders = default(List<FolderModel>), int displayOrder = default(int), string icon = default(string), string provider = default(string), LibrarySettingsModel settings = default(LibrarySettingsModel))
        {
            this.Name = name;
            this.Folders = folders;
            this.DisplayOrder = displayOrder;
            this.Icon = icon;
            this.Provider = provider;
            this.Settings = settings;
        }

        /// <summary>
        /// The ID of the library. (Read Only)
        /// </summary>
        /// <value>The ID of the library. (Read Only)</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The name of the library.
        /// </summary>
        /// <value>The name of the library.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The folders that the library is composed of on the server.
        /// </summary>
        /// <value>The folders that the library is composed of on the server.</value>
        [DataMember(Name = "folders", EmitDefaultValue = false)]
        public List<FolderModel> Folders { get; set; }

        /// <summary>
        /// Display position of the library in the list of libraries. Must be &gt;&#x3D; 1.
        /// </summary>
        /// <value>Display position of the library in the list of libraries. Must be &gt;&#x3D; 1.</value>
        [DataMember(Name = "displayOrder", EmitDefaultValue = false)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The selected icon for the library. See Library Icons for a list of possible icons.
        /// </summary>
        /// <value>The selected icon for the library. See Library Icons for a list of possible icons.</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// Preferred metadata provider for the library. See Metadata Providers for a list of possible providers.
        /// </summary>
        /// <value>Preferred metadata provider for the library. See Metadata Providers for a list of possible providers.</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public LibrarySettingsModel Settings { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library was created. (Read Only)
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library was created. (Read Only)</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public long CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// The time (in ms since POSIX epoch) when the library was last updated. (Read Only)
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library was last updated. (Read Only)</value>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public long LastUpdate { get; private set; }

        /// <summary>
        /// Returns false as LastUpdate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdate()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LibraryModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
