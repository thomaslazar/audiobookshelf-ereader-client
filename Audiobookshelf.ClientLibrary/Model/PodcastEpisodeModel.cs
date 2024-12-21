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
    /// A downloaded podcast episode.
    /// </summary>
    [DataContract(Name = "PodcastEpisode")]
    public partial class PodcastEpisodeModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisodeModel" /> class.
        /// </summary>
        /// <param name="libraryItemId">The ID of the library item that contains the podcast..</param>
        /// <param name="id">The ID of the podcast episode..</param>
        /// <param name="index">The index of the podcast episode..</param>
        /// <param name="season">The season of the podcast episode..</param>
        /// <param name="episode">The episode of the season of the podcast, if known..</param>
        /// <param name="episodeType">The type of episode that the podcast episode is..</param>
        /// <param name="title">The title of the podcast episode..</param>
        /// <param name="subtitle">The subtitle of the podcast episode..</param>
        /// <param name="description">A HTML encoded description of the podcast episode..</param>
        /// <param name="enclosure">enclosure.</param>
        /// <param name="pubDate">When the podcast episode was published..</param>
        /// <param name="audioFile">audioFile.</param>
        /// <param name="publishedAt">The time (in ms since POSIX epoch) when the podcast episode was published..</param>
        /// <param name="addedAt">The time (in ms since POSIX epoch) when the podcast episode was added to the library..</param>
        /// <param name="updatedAt">The time (in ms since POSIX epoch) when the podcast episode was last updated..</param>
        public PodcastEpisodeModel(string libraryItemId = default(string), string id = default(string), int index = default(int), string season = default(string), string episode = default(string), string episodeType = default(string), string title = default(string), string subtitle = default(string), string description = default(string), PodcastEpisodeEnclosureModel enclosure = default(PodcastEpisodeEnclosureModel), string pubDate = default(string), AudioFileModel audioFile = default(AudioFileModel), long publishedAt = default(long), long addedAt = default(long), long updatedAt = default(long))
        {
            this.LibraryItemId = libraryItemId;
            this.Id = id;
            this.Index = index;
            this.Season = season;
            this.Episode = episode;
            this.EpisodeType = episodeType;
            this.Title = title;
            this.Subtitle = subtitle;
            this.Description = description;
            this.Enclosure = enclosure;
            this.PubDate = pubDate;
            this.AudioFile = audioFile;
            this.PublishedAt = publishedAt;
            this.AddedAt = addedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The ID of the library item that contains the podcast.
        /// </summary>
        /// <value>The ID of the library item that contains the podcast.</value>
        [DataMember(Name = "libraryItemId", EmitDefaultValue = false)]
        public string LibraryItemId { get; set; }

        /// <summary>
        /// The ID of the podcast episode.
        /// </summary>
        /// <value>The ID of the podcast episode.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The index of the podcast episode.
        /// </summary>
        /// <value>The index of the podcast episode.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// The season of the podcast episode.
        /// </summary>
        /// <value>The season of the podcast episode.</value>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        public string Season { get; set; }

        /// <summary>
        /// The episode of the season of the podcast, if known.
        /// </summary>
        /// <value>The episode of the season of the podcast, if known.</value>
        [DataMember(Name = "episode", EmitDefaultValue = false)]
        public string Episode { get; set; }

        /// <summary>
        /// The type of episode that the podcast episode is.
        /// </summary>
        /// <value>The type of episode that the podcast episode is.</value>
        [DataMember(Name = "episodeType", EmitDefaultValue = false)]
        public string EpisodeType { get; set; }

        /// <summary>
        /// The title of the podcast episode.
        /// </summary>
        /// <value>The title of the podcast episode.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The subtitle of the podcast episode.
        /// </summary>
        /// <value>The subtitle of the podcast episode.</value>
        [DataMember(Name = "subtitle", EmitDefaultValue = false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// A HTML encoded description of the podcast episode.
        /// </summary>
        /// <value>A HTML encoded description of the podcast episode.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Enclosure
        /// </summary>
        [DataMember(Name = "enclosure", EmitDefaultValue = false)]
        public PodcastEpisodeEnclosureModel Enclosure { get; set; }

        /// <summary>
        /// When the podcast episode was published.
        /// </summary>
        /// <value>When the podcast episode was published.</value>
        [DataMember(Name = "pubDate", EmitDefaultValue = false)]
        public string PubDate { get; set; }

        /// <summary>
        /// Gets or Sets AudioFile
        /// </summary>
        [DataMember(Name = "audioFile", EmitDefaultValue = false)]
        public AudioFileModel AudioFile { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the podcast episode was published.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the podcast episode was published.</value>
        [DataMember(Name = "publishedAt", EmitDefaultValue = false)]
        public long PublishedAt { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the podcast episode was added to the library.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the podcast episode was added to the library.</value>
        [DataMember(Name = "addedAt", EmitDefaultValue = false)]
        public long AddedAt { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the podcast episode was last updated.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the podcast episode was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PodcastEpisodeModel {\n");
            sb.Append("  LibraryItemId: ").Append(LibraryItemId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Episode: ").Append(Episode).Append("\n");
            sb.Append("  EpisodeType: ").Append(EpisodeType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enclosure: ").Append(Enclosure).Append("\n");
            sb.Append("  PubDate: ").Append(PubDate).Append("\n");
            sb.Append("  AudioFile: ").Append(AudioFile).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
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
