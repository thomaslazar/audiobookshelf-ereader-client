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
    /// An audio file.
    /// </summary>
    [DataContract(Name = "AudioFile")]
    public partial class AudioFileModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFileModel" /> class.
        /// </summary>
        /// <param name="index">The index of the audio file..</param>
        /// <param name="ino">The inode of the audio file..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="addedAt">The time (in ms since POSIX epoch) when the audio file was added to the library..</param>
        /// <param name="updatedAt">The time (in ms since POSIX epoch) when the audio file last updated. (Read Only).</param>
        /// <param name="trackNumFromMeta">The track number from file metadata..</param>
        /// <param name="discNumFromMeta">The disc number from file metadata..</param>
        /// <param name="trackNumFromFilename">The track number from filename..</param>
        /// <param name="discNumFromFilename">The disc number from filename..</param>
        /// <param name="manuallyVerified">Whether the audio file has been manually verified..</param>
        /// <param name="exclude">Whether the audio file has been marked for exclusion..</param>
        /// <param name="error">Any error with the audio file. Null if none..</param>
        /// <param name="format">The format of the audio file..</param>
        /// <param name="duration">The total length (in seconds) of the audio file..</param>
        /// <param name="bitRate">The bit rate (in bit/s) of the audio file..</param>
        /// <param name="language">The language of the audio file..</param>
        /// <param name="codec">The codec of the audio file..</param>
        /// <param name="timeBase">The time base of the audio file..</param>
        /// <param name="channels">The number of channels the audio file has..</param>
        /// <param name="channelLayout">The layout of the audio file&#39;s channels..</param>
        /// <param name="chapters">If audiobook, the chapters the file contains..</param>
        /// <param name="embeddedCoverArt">The type of embedded cover art. Null if none..</param>
        /// <param name="metaTags">metaTags.</param>
        /// <param name="mimeType">The MIME type of the audio file..</param>
        public AudioFileModel(int index = default(int), string ino = default(string), FileMetadataModel metadata = default(FileMetadataModel), long addedAt = default(long), long updatedAt = default(long), int? trackNumFromMeta = default(int?), int? discNumFromMeta = default(int?), int? trackNumFromFilename = default(int?), int? discNumFromFilename = default(int?), bool manuallyVerified = default(bool), bool exclude = default(bool), string error = default(string), string format = default(string), decimal duration = default(decimal), int bitRate = default(int), string language = default(string), string codec = default(string), string timeBase = default(string), int channels = default(int), string channelLayout = default(string), List<BookChapterModel> chapters = default(List<BookChapterModel>), string embeddedCoverArt = default(string), AudioMetaTagsModel metaTags = default(AudioMetaTagsModel), string mimeType = default(string))
        {
            this.Index = index;
            this.Ino = ino;
            this.Metadata = metadata;
            this.AddedAt = addedAt;
            this.UpdatedAt = updatedAt;
            this.TrackNumFromMeta = trackNumFromMeta;
            this.DiscNumFromMeta = discNumFromMeta;
            this.TrackNumFromFilename = trackNumFromFilename;
            this.DiscNumFromFilename = discNumFromFilename;
            this.ManuallyVerified = manuallyVerified;
            this.Exclude = exclude;
            this.Error = error;
            this.Format = format;
            this.Duration = duration;
            this.BitRate = bitRate;
            this.Language = language;
            this.Codec = codec;
            this.TimeBase = timeBase;
            this.Channels = channels;
            this.ChannelLayout = channelLayout;
            this.Chapters = chapters;
            this.EmbeddedCoverArt = embeddedCoverArt;
            this.MetaTags = metaTags;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// The index of the audio file.
        /// </summary>
        /// <value>The index of the audio file.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// The inode of the audio file.
        /// </summary>
        /// <value>The inode of the audio file.</value>
        [DataMember(Name = "ino", EmitDefaultValue = false)]
        public string Ino { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public FileMetadataModel Metadata { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the audio file was added to the library.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the audio file was added to the library.</value>
        [DataMember(Name = "addedAt", EmitDefaultValue = false)]
        public long AddedAt { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the audio file last updated. (Read Only)
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the audio file last updated. (Read Only)</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// The track number from file metadata.
        /// </summary>
        /// <value>The track number from file metadata.</value>
        [DataMember(Name = "trackNumFromMeta", EmitDefaultValue = true)]
        public int? TrackNumFromMeta { get; set; }

        /// <summary>
        /// The disc number from file metadata.
        /// </summary>
        /// <value>The disc number from file metadata.</value>
        [DataMember(Name = "discNumFromMeta", EmitDefaultValue = true)]
        public int? DiscNumFromMeta { get; set; }

        /// <summary>
        /// The track number from filename.
        /// </summary>
        /// <value>The track number from filename.</value>
        [DataMember(Name = "trackNumFromFilename", EmitDefaultValue = true)]
        public int? TrackNumFromFilename { get; set; }

        /// <summary>
        /// The disc number from filename.
        /// </summary>
        /// <value>The disc number from filename.</value>
        [DataMember(Name = "discNumFromFilename", EmitDefaultValue = true)]
        public int? DiscNumFromFilename { get; set; }

        /// <summary>
        /// Whether the audio file has been manually verified.
        /// </summary>
        /// <value>Whether the audio file has been manually verified.</value>
        [DataMember(Name = "manuallyVerified", EmitDefaultValue = true)]
        public bool ManuallyVerified { get; set; }

        /// <summary>
        /// Whether the audio file has been marked for exclusion.
        /// </summary>
        /// <value>Whether the audio file has been marked for exclusion.</value>
        [DataMember(Name = "exclude", EmitDefaultValue = true)]
        public bool Exclude { get; set; }

        /// <summary>
        /// Any error with the audio file. Null if none.
        /// </summary>
        /// <value>Any error with the audio file. Null if none.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The format of the audio file.
        /// </summary>
        /// <value>The format of the audio file.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// The total length (in seconds) of the audio file.
        /// </summary>
        /// <value>The total length (in seconds) of the audio file.</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public decimal Duration { get; set; }

        /// <summary>
        /// The bit rate (in bit/s) of the audio file.
        /// </summary>
        /// <value>The bit rate (in bit/s) of the audio file.</value>
        [DataMember(Name = "bitRate", EmitDefaultValue = false)]
        public int BitRate { get; set; }

        /// <summary>
        /// The language of the audio file.
        /// </summary>
        /// <value>The language of the audio file.</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// The codec of the audio file.
        /// </summary>
        /// <value>The codec of the audio file.</value>
        [DataMember(Name = "codec", EmitDefaultValue = false)]
        public string Codec { get; set; }

        /// <summary>
        /// The time base of the audio file.
        /// </summary>
        /// <value>The time base of the audio file.</value>
        [DataMember(Name = "timeBase", EmitDefaultValue = false)]
        public string TimeBase { get; set; }

        /// <summary>
        /// The number of channels the audio file has.
        /// </summary>
        /// <value>The number of channels the audio file has.</value>
        [DataMember(Name = "channels", EmitDefaultValue = false)]
        public int Channels { get; set; }

        /// <summary>
        /// The layout of the audio file&#39;s channels.
        /// </summary>
        /// <value>The layout of the audio file&#39;s channels.</value>
        [DataMember(Name = "channelLayout", EmitDefaultValue = false)]
        public string ChannelLayout { get; set; }

        /// <summary>
        /// If audiobook, the chapters the file contains.
        /// </summary>
        /// <value>If audiobook, the chapters the file contains.</value>
        [DataMember(Name = "chapters", EmitDefaultValue = false)]
        public List<BookChapterModel> Chapters { get; set; }

        /// <summary>
        /// The type of embedded cover art. Null if none.
        /// </summary>
        /// <value>The type of embedded cover art. Null if none.</value>
        [DataMember(Name = "embeddedCoverArt", EmitDefaultValue = true)]
        public string EmbeddedCoverArt { get; set; }

        /// <summary>
        /// Gets or Sets MetaTags
        /// </summary>
        [DataMember(Name = "metaTags", EmitDefaultValue = false)]
        public AudioMetaTagsModel MetaTags { get; set; }

        /// <summary>
        /// The MIME type of the audio file.
        /// </summary>
        /// <value>The MIME type of the audio file.</value>
        [DataMember(Name = "mimeType", EmitDefaultValue = false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudioFileModel {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Ino: ").Append(Ino).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  AddedAt: ").Append(AddedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  TrackNumFromMeta: ").Append(TrackNumFromMeta).Append("\n");
            sb.Append("  DiscNumFromMeta: ").Append(DiscNumFromMeta).Append("\n");
            sb.Append("  TrackNumFromFilename: ").Append(TrackNumFromFilename).Append("\n");
            sb.Append("  DiscNumFromFilename: ").Append(DiscNumFromFilename).Append("\n");
            sb.Append("  ManuallyVerified: ").Append(ManuallyVerified).Append("\n");
            sb.Append("  Exclude: ").Append(Exclude).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  BitRate: ").Append(BitRate).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Codec: ").Append(Codec).Append("\n");
            sb.Append("  TimeBase: ").Append(TimeBase).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  ChannelLayout: ").Append(ChannelLayout).Append("\n");
            sb.Append("  Chapters: ").Append(Chapters).Append("\n");
            sb.Append("  EmbeddedCoverArt: ").Append(EmbeddedCoverArt).Append("\n");
            sb.Append("  MetaTags: ").Append(MetaTags).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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