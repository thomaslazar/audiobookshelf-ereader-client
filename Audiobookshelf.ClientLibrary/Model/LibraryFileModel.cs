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
    /// A file in the library.
    /// </summary>
    [DataContract(Name = "LibraryFile")]
    public partial class LibraryFileModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryFileModel" /> class.
        /// </summary>
        /// <param name="ino">The inode of the library file..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="addedAt">The time (in ms since POSIX epoch) when the library file was added..</param>
        /// <param name="updatedAt">The time (in ms since POSIX epoch) when the library file was last updated..</param>
        /// <param name="fileType">The type of file that the library file is (audio, image, etc.)..</param>
        public LibraryFileModel(string ino = default(string), FileMetadataModel metadata = default(FileMetadataModel), long addedAt = default(long), long updatedAt = default(long), string fileType = default(string))
        {
            this.Ino = ino;
            this.Metadata = metadata;
            this.AddedAt = addedAt;
            this.UpdatedAt = updatedAt;
            this.FileType = fileType;
        }

        /// <summary>
        /// The inode of the library file.
        /// </summary>
        /// <value>The inode of the library file.</value>
        [DataMember(Name = "ino", EmitDefaultValue = false)]
        public string Ino { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public FileMetadataModel Metadata { get; set; }

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
        /// The type of file that the library file is (audio, image, etc.).
        /// </summary>
        /// <value>The type of file that the library file is (audio, image, etc.).</value>
        [DataMember(Name = "fileType", EmitDefaultValue = false)]
        public string FileType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LibraryFileModel {\n");
            sb.Append("  Ino: ").Append(Ino).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AddedAt: ").Append(AddedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
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