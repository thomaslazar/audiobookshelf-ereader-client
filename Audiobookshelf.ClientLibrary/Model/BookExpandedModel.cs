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
    /// An expanded version of Book.
    /// </summary>
    [DataContract(Name = "BookExpanded")]
    public partial class BookExpandedModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookExpandedModel" /> class.
        /// </summary>
        /// <param name="id">ID of the library item..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="coverPath">Cover path..</param>
        /// <param name="tags">Tags..</param>
        /// <param name="audioFiles">Audio files..</param>
        /// <param name="chapters">Chapters..</param>
        /// <param name="duration">Total length in seconds..</param>
        /// <param name="size">Total size in bytes..</param>
        /// <param name="tracks">Audio tracks..</param>
        /// <param name="ebookFile">ebookFile.</param>
        public BookExpandedModel(string id = default(string), BookMetadataExpandedModel metadata = default(BookMetadataExpandedModel), string coverPath = default(string), List<string> tags = default(List<string>), List<AudioFileModel> audioFiles = default(List<AudioFileModel>), List<BookChapterModel> chapters = default(List<BookChapterModel>), decimal duration = default(decimal), int size = default(int), List<AudioTrackModel> tracks = default(List<AudioTrackModel>), EBookFileModel ebookFile = default(EBookFileModel))
        {
            this.Id = id;
            this.Metadata = metadata;
            this.CoverPath = coverPath;
            this.Tags = tags;
            this.AudioFiles = audioFiles;
            this.Chapters = chapters;
            this.Duration = duration;
            this.Size = size;
            this.Tracks = tracks;
            this.EbookFile = ebookFile;
        }

        /// <summary>
        /// ID of the library item.
        /// </summary>
        /// <value>ID of the library item.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public BookMetadataExpandedModel Metadata { get; set; }

        /// <summary>
        /// Cover path.
        /// </summary>
        /// <value>Cover path.</value>
        [DataMember(Name = "coverPath", EmitDefaultValue = true)]
        public string CoverPath { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        /// <value>Tags.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Audio files.
        /// </summary>
        /// <value>Audio files.</value>
        [DataMember(Name = "audioFiles", EmitDefaultValue = false)]
        public List<AudioFileModel> AudioFiles { get; set; }

        /// <summary>
        /// Chapters.
        /// </summary>
        /// <value>Chapters.</value>
        [DataMember(Name = "chapters", EmitDefaultValue = false)]
        public List<BookChapterModel> Chapters { get; set; }

        /// <summary>
        /// Total length in seconds.
        /// </summary>
        /// <value>Total length in seconds.</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public decimal Duration { get; set; }

        /// <summary>
        /// Total size in bytes.
        /// </summary>
        /// <value>Total size in bytes.</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Audio tracks.
        /// </summary>
        /// <value>Audio tracks.</value>
        [DataMember(Name = "tracks", EmitDefaultValue = false)]
        public List<AudioTrackModel> Tracks { get; set; }

        /// <summary>
        /// Gets or Sets EbookFile
        /// </summary>
        [DataMember(Name = "ebookFile", EmitDefaultValue = false)]
        public EBookFileModel EbookFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BookExpandedModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CoverPath: ").Append(CoverPath).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  AudioFiles: ").Append(AudioFiles).Append("\n");
            sb.Append("  Chapters: ").Append(Chapters).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Tracks: ").Append(Tracks).Append("\n");
            sb.Append("  EbookFile: ").Append(EbookFile).Append("\n");
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
