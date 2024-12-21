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
    /// A podcast object.
    /// </summary>
    [DataContract(Name = "Podcast")]
    public partial class PodcastModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastModel" /> class.
        /// </summary>
        /// <param name="libraryItemId">The ID of the library item that contains the podcast..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="coverPath">The absolute path on the server of the cover file..</param>
        /// <param name="tags">The podcast&#39;s tags..</param>
        /// <param name="episodes">The downloaded episodes of the podcast..</param>
        /// <param name="autoDownloadEpisodes">Whether the server will automatically download podcast episodes according to the schedule..</param>
        /// <param name="autoDownloadSchedule">The cron expression for when to automatically download podcast episodes. If autoDownloadEpisodes is false, may not exist..</param>
        /// <param name="lastEpisodeCheck">The time (in ms since POSIX epoch) when the podcast was checked for new episodes..</param>
        /// <param name="maxEpisodesToKeep">The maximum number of podcast episodes to keep. If 0, all episodes will be kept..</param>
        /// <param name="maxNewEpisodesToDownload">The maximum number of podcast episodes to download when automatically downloading new episodes. If 0, all episodes will be downloaded..</param>
        public PodcastModel(string libraryItemId = default(string), PodcastMetadataModel metadata = default(PodcastMetadataModel), string coverPath = default(string), List<string> tags = default(List<string>), List<PodcastEpisodeModel> episodes = default(List<PodcastEpisodeModel>), bool autoDownloadEpisodes = default(bool), string autoDownloadSchedule = default(string), long lastEpisodeCheck = default(long), int maxEpisodesToKeep = default(int), int maxNewEpisodesToDownload = default(int))
        {
            this.LibraryItemId = libraryItemId;
            this.Metadata = metadata;
            this.CoverPath = coverPath;
            this.Tags = tags;
            this.Episodes = episodes;
            this.AutoDownloadEpisodes = autoDownloadEpisodes;
            this.AutoDownloadSchedule = autoDownloadSchedule;
            this.LastEpisodeCheck = lastEpisodeCheck;
            this.MaxEpisodesToKeep = maxEpisodesToKeep;
            this.MaxNewEpisodesToDownload = maxNewEpisodesToDownload;
        }

        /// <summary>
        /// The ID of the library item that contains the podcast.
        /// </summary>
        /// <value>The ID of the library item that contains the podcast.</value>
        [DataMember(Name = "libraryItemId", EmitDefaultValue = false)]
        public string LibraryItemId { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public PodcastMetadataModel Metadata { get; set; }

        /// <summary>
        /// The absolute path on the server of the cover file.
        /// </summary>
        /// <value>The absolute path on the server of the cover file.</value>
        [DataMember(Name = "coverPath", EmitDefaultValue = true)]
        public string CoverPath { get; set; }

        /// <summary>
        /// The podcast&#39;s tags.
        /// </summary>
        /// <value>The podcast&#39;s tags.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The downloaded episodes of the podcast.
        /// </summary>
        /// <value>The downloaded episodes of the podcast.</value>
        [DataMember(Name = "episodes", EmitDefaultValue = false)]
        public List<PodcastEpisodeModel> Episodes { get; set; }

        /// <summary>
        /// Whether the server will automatically download podcast episodes according to the schedule.
        /// </summary>
        /// <value>Whether the server will automatically download podcast episodes according to the schedule.</value>
        [DataMember(Name = "autoDownloadEpisodes", EmitDefaultValue = true)]
        public bool AutoDownloadEpisodes { get; set; }

        /// <summary>
        /// The cron expression for when to automatically download podcast episodes. If autoDownloadEpisodes is false, may not exist.
        /// </summary>
        /// <value>The cron expression for when to automatically download podcast episodes. If autoDownloadEpisodes is false, may not exist.</value>
        [DataMember(Name = "autoDownloadSchedule", EmitDefaultValue = true)]
        public string AutoDownloadSchedule { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the podcast was checked for new episodes.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the podcast was checked for new episodes.</value>
        [DataMember(Name = "lastEpisodeCheck", EmitDefaultValue = false)]
        public long LastEpisodeCheck { get; set; }

        /// <summary>
        /// The maximum number of podcast episodes to keep. If 0, all episodes will be kept.
        /// </summary>
        /// <value>The maximum number of podcast episodes to keep. If 0, all episodes will be kept.</value>
        [DataMember(Name = "maxEpisodesToKeep", EmitDefaultValue = false)]
        public int MaxEpisodesToKeep { get; set; }

        /// <summary>
        /// The maximum number of podcast episodes to download when automatically downloading new episodes. If 0, all episodes will be downloaded.
        /// </summary>
        /// <value>The maximum number of podcast episodes to download when automatically downloading new episodes. If 0, all episodes will be downloaded.</value>
        [DataMember(Name = "maxNewEpisodesToDownload", EmitDefaultValue = false)]
        public int MaxNewEpisodesToDownload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PodcastModel {\n");
            sb.Append("  LibraryItemId: ").Append(LibraryItemId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CoverPath: ").Append(CoverPath).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Episodes: ").Append(Episodes).Append("\n");
            sb.Append("  AutoDownloadEpisodes: ").Append(AutoDownloadEpisodes).Append("\n");
            sb.Append("  AutoDownloadSchedule: ").Append(AutoDownloadSchedule).Append("\n");
            sb.Append("  LastEpisodeCheck: ").Append(LastEpisodeCheck).Append("\n");
            sb.Append("  MaxEpisodesToKeep: ").Append(MaxEpisodesToKeep).Append("\n");
            sb.Append("  MaxNewEpisodesToDownload: ").Append(MaxNewEpisodesToDownload).Append("\n");
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