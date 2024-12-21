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
    /// A library item.
    /// </summary>
    [DataContract(Name = "LibraryItem")]
    public partial class LibraryItemModel : IValidatableObject
    {
        /// <summary>
        /// What kind of media the library item contains. Will be book or podcast.
        /// </summary>
        /// <value>What kind of media the library item contains. Will be book or podcast.</value>
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
        /// What kind of media the library item contains. Will be book or podcast.
        /// </summary>
        /// <value>What kind of media the library item contains. Will be book or podcast.</value>
        [DataMember(Name = "mediaType", EmitDefaultValue = false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryItemModel" /> class.
        /// </summary>
        /// <param name="id">The ID of the library item..</param>
        /// <param name="ino">The inode of the library item..</param>
        /// <param name="libraryId">The ID of the library the item belongs to..</param>
        /// <param name="folderId">The ID of the folder the library item is in..</param>
        /// <param name="path">The path of the library item on the server..</param>
        /// <param name="relPath">The path, relative to the library folder, of the library item..</param>
        /// <param name="isFile">Whether the library item is a single file in the root of the library folder..</param>
        /// <param name="mtimeMs">The time (in ms since POSIX epoch) when the library item was last modified on disk..</param>
        /// <param name="ctimeMs">The time (in ms since POSIX epoch) when the library item status was changed on disk..</param>
        /// <param name="birthtimeMs">The time (in ms since POSIX epoch) when the library item was created on disk. Will be 0 if unknown..</param>
        /// <param name="addedAt">The time (in ms since POSIX epoch) when the library item was added to the library..</param>
        /// <param name="lastScan">The time (in ms since POSIX epoch) when the library item was last scanned. Will be null if the server has not yet scanned the library item..</param>
        /// <param name="scanVersion">The version of the scanner when last scanned. Will be null if it has not been scanned..</param>
        /// <param name="isMissing">Whether the library item was scanned and no longer exists..</param>
        /// <param name="isInvalid">Whether the library item was scanned and no longer has media files..</param>
        /// <param name="mediaType">What kind of media the library item contains. Will be book or podcast..</param>
        /// <param name="media">media.</param>
        /// <param name="libraryFiles">The files of the library item..</param>
        public LibraryItemModel(string id = default(string), string ino = default(string), string libraryId = default(string), string folderId = default(string), string path = default(string), string relPath = default(string), bool isFile = default(bool), long mtimeMs = default(long), long ctimeMs = default(long), long birthtimeMs = default(long), long addedAt = default(long), long? lastScan = default(long?), string scanVersion = default(string), bool isMissing = default(bool), bool isInvalid = default(bool), MediaTypeEnum? mediaType = default(MediaTypeEnum?), LibraryItemMediaModel media = default(LibraryItemMediaModel), List<LibraryFileModel> libraryFiles = default(List<LibraryFileModel>))
        {
            this.Id = id;
            this.Ino = ino;
            this.LibraryId = libraryId;
            this.FolderId = folderId;
            this.Path = path;
            this.RelPath = relPath;
            this.IsFile = isFile;
            this.MtimeMs = mtimeMs;
            this.CtimeMs = ctimeMs;
            this.BirthtimeMs = birthtimeMs;
            this.AddedAt = addedAt;
            this.LastScan = lastScan;
            this.ScanVersion = scanVersion;
            this.IsMissing = isMissing;
            this.IsInvalid = isInvalid;
            this.MediaType = mediaType;
            this.Media = media;
            this.LibraryFiles = libraryFiles;
        }

        /// <summary>
        /// The ID of the library item.
        /// </summary>
        /// <value>The ID of the library item.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The inode of the library item.
        /// </summary>
        /// <value>The inode of the library item.</value>
        [DataMember(Name = "ino", EmitDefaultValue = false)]
        public string Ino { get; set; }

        /// <summary>
        /// The ID of the library the item belongs to.
        /// </summary>
        /// <value>The ID of the library the item belongs to.</value>
        [DataMember(Name = "libraryId", EmitDefaultValue = false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// The ID of the folder the library item is in.
        /// </summary>
        /// <value>The ID of the folder the library item is in.</value>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public string FolderId { get; set; }

        /// <summary>
        /// The path of the library item on the server.
        /// </summary>
        /// <value>The path of the library item on the server.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// The path, relative to the library folder, of the library item.
        /// </summary>
        /// <value>The path, relative to the library folder, of the library item.</value>
        [DataMember(Name = "relPath", EmitDefaultValue = false)]
        public string RelPath { get; set; }

        /// <summary>
        /// Whether the library item is a single file in the root of the library folder.
        /// </summary>
        /// <value>Whether the library item is a single file in the root of the library folder.</value>
        [DataMember(Name = "isFile", EmitDefaultValue = true)]
        public bool IsFile { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library item was last modified on disk.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library item was last modified on disk.</value>
        [DataMember(Name = "mtimeMs", EmitDefaultValue = false)]
        public long MtimeMs { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library item status was changed on disk.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library item status was changed on disk.</value>
        [DataMember(Name = "ctimeMs", EmitDefaultValue = false)]
        public long CtimeMs { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library item was created on disk. Will be 0 if unknown.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library item was created on disk. Will be 0 if unknown.</value>
        [DataMember(Name = "birthtimeMs", EmitDefaultValue = false)]
        public long BirthtimeMs { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library item was added to the library.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library item was added to the library.</value>
        [DataMember(Name = "addedAt", EmitDefaultValue = false)]
        public long AddedAt { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the library item was last updated. (Read Only)
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library item was last updated. (Read Only)</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public long UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The time (in ms since POSIX epoch) when the library item was last scanned. Will be null if the server has not yet scanned the library item.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the library item was last scanned. Will be null if the server has not yet scanned the library item.</value>
        [DataMember(Name = "lastScan", EmitDefaultValue = true)]
        public long? LastScan { get; set; }

        /// <summary>
        /// The version of the scanner when last scanned. Will be null if it has not been scanned.
        /// </summary>
        /// <value>The version of the scanner when last scanned. Will be null if it has not been scanned.</value>
        [DataMember(Name = "scanVersion", EmitDefaultValue = true)]
        public string ScanVersion { get; set; }

        /// <summary>
        /// Whether the library item was scanned and no longer exists.
        /// </summary>
        /// <value>Whether the library item was scanned and no longer exists.</value>
        [DataMember(Name = "isMissing", EmitDefaultValue = true)]
        public bool IsMissing { get; set; }

        /// <summary>
        /// Whether the library item was scanned and no longer has media files.
        /// </summary>
        /// <value>Whether the library item was scanned and no longer has media files.</value>
        [DataMember(Name = "isInvalid", EmitDefaultValue = true)]
        public bool IsInvalid { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public LibraryItemMediaModel Media { get; set; }

        /// <summary>
        /// The files of the library item.
        /// </summary>
        /// <value>The files of the library item.</value>
        [DataMember(Name = "libraryFiles", EmitDefaultValue = false)]
        public List<LibraryFileModel> LibraryFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LibraryItemModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ino: ").Append(Ino).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  RelPath: ").Append(RelPath).Append("\n");
            sb.Append("  IsFile: ").Append(IsFile).Append("\n");
            sb.Append("  MtimeMs: ").Append(MtimeMs).Append("\n");
            sb.Append("  CtimeMs: ").Append(CtimeMs).Append("\n");
            sb.Append("  BirthtimeMs: ").Append(BirthtimeMs).Append("\n");
            sb.Append("  AddedAt: ").Append(AddedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  LastScan: ").Append(LastScan).Append("\n");
            sb.Append("  ScanVersion: ").Append(ScanVersion).Append("\n");
            sb.Append("  IsMissing: ").Append(IsMissing).Append("\n");
            sb.Append("  IsInvalid: ").Append(IsInvalid).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  LibraryFiles: ").Append(LibraryFiles).Append("\n");
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
