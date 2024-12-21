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
    /// A podcast feed episode from the RSS feed.
    /// </summary>
    [DataContract(Name = "PodcastFeedEpisode")]
    public partial class PodcastFeedEpisodeModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastFeedEpisodeModel" /> class.
        /// </summary>
        /// <param name="title">The podcast episode&#39;s title..</param>
        /// <param name="subtitle">The podcast episode&#39;s subtitle..</param>
        /// <param name="description">A HTML encoded description of the podcast episode..</param>
        /// <param name="descriptionPlain">A plain text description of the podcast episode..</param>
        /// <param name="pubDate">The podcast episode&#39;s publication date..</param>
        /// <param name="episodeType">The type of episode..</param>
        /// <param name="season">The season of the podcast episode..</param>
        /// <param name="episode">The episode of the season of the podcast..</param>
        /// <param name="author">The author of the podcast episode..</param>
        /// <param name="duration">The duration of the podcast episode as reported by the RSS feed..</param>
        /// <param name="varExplicit">Whether the podcast episode is explicit..</param>
        /// <param name="publishedAt">The time (in ms since POSIX epoch) when the podcast episode was published..</param>
        /// <param name="enclosure">enclosure.</param>
        public PodcastFeedEpisodeModel(string title = default(string), string subtitle = default(string), string description = default(string), string descriptionPlain = default(string), string pubDate = default(string), string episodeType = default(string), string season = default(string), string episode = default(string), string author = default(string), string duration = default(string), string varExplicit = default(string), long publishedAt = default(long), PodcastEpisodeEnclosureModel enclosure = default(PodcastEpisodeEnclosureModel))
        {
            this.Title = title;
            this.Subtitle = subtitle;
            this.Description = description;
            this.DescriptionPlain = descriptionPlain;
            this.PubDate = pubDate;
            this.EpisodeType = episodeType;
            this.Season = season;
            this.Episode = episode;
            this.Author = author;
            this.Duration = duration;
            this.Explicit = varExplicit;
            this.PublishedAt = publishedAt;
            this.Enclosure = enclosure;
        }

        /// <summary>
        /// The podcast episode&#39;s title.
        /// </summary>
        /// <value>The podcast episode&#39;s title.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The podcast episode&#39;s subtitle.
        /// </summary>
        /// <value>The podcast episode&#39;s subtitle.</value>
        [DataMember(Name = "subtitle", EmitDefaultValue = false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// A HTML encoded description of the podcast episode.
        /// </summary>
        /// <value>A HTML encoded description of the podcast episode.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A plain text description of the podcast episode.
        /// </summary>
        /// <value>A plain text description of the podcast episode.</value>
        [DataMember(Name = "descriptionPlain", EmitDefaultValue = false)]
        public string DescriptionPlain { get; set; }

        /// <summary>
        /// The podcast episode&#39;s publication date.
        /// </summary>
        /// <value>The podcast episode&#39;s publication date.</value>
        [DataMember(Name = "pubDate", EmitDefaultValue = false)]
        public string PubDate { get; set; }

        /// <summary>
        /// The type of episode.
        /// </summary>
        /// <value>The type of episode.</value>
        [DataMember(Name = "episodeType", EmitDefaultValue = false)]
        public string EpisodeType { get; set; }

        /// <summary>
        /// The season of the podcast episode.
        /// </summary>
        /// <value>The season of the podcast episode.</value>
        [DataMember(Name = "season", EmitDefaultValue = false)]
        public string Season { get; set; }

        /// <summary>
        /// The episode of the season of the podcast.
        /// </summary>
        /// <value>The episode of the season of the podcast.</value>
        [DataMember(Name = "episode", EmitDefaultValue = false)]
        public string Episode { get; set; }

        /// <summary>
        /// The author of the podcast episode.
        /// </summary>
        /// <value>The author of the podcast episode.</value>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public string Author { get; set; }

        /// <summary>
        /// The duration of the podcast episode as reported by the RSS feed.
        /// </summary>
        /// <value>The duration of the podcast episode as reported by the RSS feed.</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// Whether the podcast episode is explicit.
        /// </summary>
        /// <value>Whether the podcast episode is explicit.</value>
        [DataMember(Name = "explicit", EmitDefaultValue = false)]
        public string Explicit { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the podcast episode was published.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the podcast episode was published.</value>
        [DataMember(Name = "publishedAt", EmitDefaultValue = false)]
        public long PublishedAt { get; set; }

        /// <summary>
        /// Gets or Sets Enclosure
        /// </summary>
        [DataMember(Name = "enclosure", EmitDefaultValue = false)]
        public PodcastEpisodeEnclosureModel Enclosure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PodcastFeedEpisodeModel {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionPlain: ").Append(DescriptionPlain).Append("\n");
            sb.Append("  PubDate: ").Append(PubDate).Append("\n");
            sb.Append("  EpisodeType: ").Append(EpisodeType).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Episode: ").Append(Episode).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Explicit: ").Append(Explicit).Append("\n");
            sb.Append("  PublishedAt: ").Append(PublishedAt).Append("\n");
            sb.Append("  Enclosure: ").Append(Enclosure).Append("\n");
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
