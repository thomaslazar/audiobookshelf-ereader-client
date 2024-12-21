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
    /// An ebook file.
    /// </summary>
    [DataContract(Name = "EBookFile")]
    public partial class EBookFileModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EBookFileModel" /> class.
        /// </summary>
        /// <param name="ino">The inode of the ebook file..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="ebookFormat">The ebook format of the ebook file..</param>
        /// <param name="addedAt">The time (in ms since POSIX epoch) when the library file was added..</param>
        /// <param name="updatedAt">The time (in ms since POSIX epoch) when the library file was last updated..</param>
        public EBookFileModel(string ino = default(string), FileMetadataModel metadata = default(FileMetadataModel), string ebookFormat = default(string), long addedAt = default(long), long updatedAt = default(long))
        {
            this.Ino = ino;
            this.Metadata = metadata;
            this.EbookFormat = ebookFormat;
            this.AddedAt = addedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The inode of the ebook file.
        /// </summary>
        /// <value>The inode of the ebook file.</value>
        [DataMember(Name = "ino", EmitDefaultValue = false)]
        public string Ino { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public FileMetadataModel Metadata { get; set; }

        /// <summary>
        /// The ebook format of the ebook file.
        /// </summary>
        /// <value>The ebook format of the ebook file.</value>
        [DataMember(Name = "ebookFormat", EmitDefaultValue = false)]
        public string EbookFormat { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library file was added.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library file was added.</value>
        [DataMember(Name = "addedAt", EmitDefaultValue = false)]
        public long AddedAt { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library file was last updated.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library file was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EBookFileModel {\n");
            sb.Append("  Ino: ").Append(Ino).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  EbookFormat: ").Append(EbookFormat).Append("\n");
            sb.Append("  AddedAt: ").Append(AddedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
