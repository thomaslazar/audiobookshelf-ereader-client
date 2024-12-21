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
    /// An expanded form of a library item.
    /// </summary>
    [DataContract(Name = "LibraryItemExpanded")]
    public partial class LibraryItemExpandedModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryItemExpandedModel" /> class.
        /// </summary>
        /// <param name="id">The ID of the library item..</param>
        /// <param name="ino">The inode..</param>
        /// <param name="libraryId">Library ID..</param>
        /// <param name="folderId">Folder ID..</param>
        /// <param name="path">Absolute path..</param>
        /// <param name="relPath">Relative path..</param>
        /// <param name="isFile">Is a single file?.</param>
        /// <param name="mtimeMs">Last modified time..</param>
        /// <param name="ctimeMs">Change time..</param>
        /// <param name="birthtimeMs">Birth time..</param>
        /// <param name="addedAt">Time added..</param>
        /// <param name="updatedAt">Time updated..</param>
        /// <param name="lastScan">Last scan time..</param>
        /// <param name="scanVersion">Scanner version..</param>
        /// <param name="isMissing">Is missing?.</param>
        /// <param name="isInvalid">Is invalid?.</param>
        /// <param name="mediaType">Media type (book or podcast)..</param>
        /// <param name="media">media.</param>
        /// <param name="libraryFiles">The item&#39;s files..</param>
        /// <param name="size">Total size in bytes..</param>
        public LibraryItemExpandedModel(string id = default(string), string ino = default(string), string libraryId = default(string), string folderId = default(string), string path = default(string), string relPath = default(string), bool isFile = default(bool), long mtimeMs = default(long), long ctimeMs = default(long), long birthtimeMs = default(long), long addedAt = default(long), long updatedAt = default(long), long? lastScan = default(long?), string scanVersion = default(string), bool isMissing = default(bool), bool isInvalid = default(bool), string mediaType = default(string), LibraryItemExpandedMediaModel media = default(LibraryItemExpandedMediaModel), List<LibraryFileModel> libraryFiles = default(List<LibraryFileModel>), int size = default(int))
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
            this.UpdatedAt = updatedAt;
            this.LastScan = lastScan;
            this.ScanVersion = scanVersion;
            this.IsMissing = isMissing;
            this.IsInvalid = isInvalid;
            this.MediaType = mediaType;
            this.Media = media;
            this.LibraryFiles = libraryFiles;
            this.Size = size;
        }

        /// <summary>
        /// The ID of the library item.
        /// </summary>
        /// <value>The ID of the library item.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The inode.
        /// </summary>
        /// <value>The inode.</value>
        [DataMember(Name = "ino", EmitDefaultValue = false)]
        public string Ino { get; set; }

        /// <summary>
        /// Library ID.
        /// </summary>
        /// <value>Library ID.</value>
        [DataMember(Name = "libraryId", EmitDefaultValue = false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// Folder ID.
        /// </summary>
        /// <value>Folder ID.</value>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public string FolderId { get; set; }

        /// <summary>
        /// Absolute path.
        /// </summary>
        /// <value>Absolute path.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Relative path.
        /// </summary>
        /// <value>Relative path.</value>
        [DataMember(Name = "relPath", EmitDefaultValue = false)]
        public string RelPath { get; set; }

        /// <summary>
        /// Is a single file?
        /// </summary>
        /// <value>Is a single file?</value>
        [DataMember(Name = "isFile", EmitDefaultValue = true)]
        public bool IsFile { get; set; }

        /// <summary>
        /// Last modified time.
        /// </summary>
        /// <value>Last modified time.</value>
        [DataMember(Name = "mtimeMs", EmitDefaultValue = false)]
        public long MtimeMs { get; set; }

        /// <summary>
        /// Change time.
        /// </summary>
        /// <value>Change time.</value>
        [DataMember(Name = "ctimeMs", EmitDefaultValue = false)]
        public long CtimeMs { get; set; }

        /// <summary>
        /// Birth time.
        /// </summary>
        /// <value>Birth time.</value>
        [DataMember(Name = "birthtimeMs", EmitDefaultValue = false)]
        public long BirthtimeMs { get; set; }

        /// <summary>
        /// Time added.
        /// </summary>
        /// <value>Time added.</value>
        [DataMember(Name = "addedAt", EmitDefaultValue = false)]
        public long AddedAt { get; set; }

        /// <summary>
        /// Time updated.
        /// </summary>
        /// <value>Time updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// Last scan time.
        /// </summary>
        /// <value>Last scan time.</value>
        [DataMember(Name = "lastScan", EmitDefaultValue = true)]
        public long? LastScan { get; set; }

        /// <summary>
        /// Scanner version.
        /// </summary>
        /// <value>Scanner version.</value>
        [DataMember(Name = "scanVersion", EmitDefaultValue = true)]
        public string ScanVersion { get; set; }

        /// <summary>
        /// Is missing?
        /// </summary>
        /// <value>Is missing?</value>
        [DataMember(Name = "isMissing", EmitDefaultValue = true)]
        public bool IsMissing { get; set; }

        /// <summary>
        /// Is invalid?
        /// </summary>
        /// <value>Is invalid?</value>
        [DataMember(Name = "isInvalid", EmitDefaultValue = true)]
        public bool IsInvalid { get; set; }

        /// <summary>
        /// Media type (book or podcast).
        /// </summary>
        /// <value>Media type (book or podcast).</value>
        [DataMember(Name = "mediaType", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public LibraryItemExpandedMediaModel Media { get; set; }

        /// <summary>
        /// The item&#39;s files.
        /// </summary>
        /// <value>The item&#39;s files.</value>
        [DataMember(Name = "libraryFiles", EmitDefaultValue = false)]
        public List<LibraryFileModel> LibraryFiles { get; set; }

        /// <summary>
        /// Total size in bytes.
        /// </summary>
        /// <value>Total size in bytes.</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LibraryItemExpandedModel {\n");
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
            sb.Append("  Size: ").Append(Size).Append("\n");
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