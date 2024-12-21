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
    /// Podcast Metadata Object.
    /// </summary>
    [DataContract(Name = "PodcastMetadata")]
    public partial class PodcastMetadataModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastMetadataModel" /> class.
        /// </summary>
        /// <param name="title">The title of the podcast. Will be null if unknown..</param>
        /// <param name="author">The author of the podcast. Will be null if unknown..</param>
        /// <param name="description">The description for the podcast. Will be null if unknown..</param>
        /// <param name="releaseDate">The release date of the podcast. Will be null if unknown..</param>
        /// <param name="genres">The podcast&#39;s genres..</param>
        /// <param name="feedUrl">A URL of an RSS feed for the podcast. Will be null if unknown..</param>
        /// <param name="imageUrl">A URL of a cover image for the podcast. Will be null if unknown..</param>
        /// <param name="itunesPageUrl">A URL of an iTunes page for the podcast. Will be null if unknown..</param>
        /// <param name="itunesId">The iTunes ID for the podcast. Will be null if unknown..</param>
        /// <param name="itunesArtistId">The iTunes Artist ID for the author of the podcast. Will be null if unknown..</param>
        /// <param name="varExplicit">Whether the podcast has been marked as explicit..</param>
        /// <param name="language">The language of the podcast. Will be null if unknown..</param>
        /// <param name="type">The type of the podcast..</param>
        public PodcastMetadataModel(string title = default(string), string author = default(string), string description = default(string), string releaseDate = default(string), List<string> genres = default(List<string>), string feedUrl = default(string), string imageUrl = default(string), string itunesPageUrl = default(string), int? itunesId = default(int?), int? itunesArtistId = default(int?), bool varExplicit = default(bool), string language = default(string), string type = default(string))
        {
            this.Title = title;
            this.Author = author;
            this.Description = description;
            this.ReleaseDate = releaseDate;
            this.Genres = genres;
            this.FeedUrl = feedUrl;
            this.ImageUrl = imageUrl;
            this.ItunesPageUrl = itunesPageUrl;
            this.ItunesId = itunesId;
            this.ItunesArtistId = itunesArtistId;
            this.Explicit = varExplicit;
            this.Language = language;
            this.Type = type;
        }

        /// <summary>
        /// The title of the podcast. Will be null if unknown.
        /// </summary>
        /// <value>The title of the podcast. Will be null if unknown.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The author of the podcast. Will be null if unknown.
        /// </summary>
        /// <value>The author of the podcast. Will be null if unknown.</value>
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// The description for the podcast. Will be null if unknown.
        /// </summary>
        /// <value>The description for the podcast. Will be null if unknown.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The release date of the podcast. Will be null if unknown.
        /// </summary>
        /// <value>The release date of the podcast. Will be null if unknown.</value>
        [DataMember(Name = "releaseDate", EmitDefaultValue = true)]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// The podcast&#39;s genres.
        /// </summary>
        /// <value>The podcast&#39;s genres.</value>
        [DataMember(Name = "genres", EmitDefaultValue = false)]
        public List<string> Genres { get; set; }

        /// <summary>
        /// A URL of an RSS feed for the podcast. Will be null if unknown.
        /// </summary>
        /// <value>A URL of an RSS feed for the podcast. Will be null if unknown.</value>
        [DataMember(Name = "feedUrl", EmitDefaultValue = true)]
        public string FeedUrl { get; set; }

        /// <summary>
        /// A URL of a cover image for the podcast. Will be null if unknown.
        /// </summary>
        /// <value>A URL of a cover image for the podcast. Will be null if unknown.</value>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// A URL of an iTunes page for the podcast. Will be null if unknown.
        /// </summary>
        /// <value>A URL of an iTunes page for the podcast. Will be null if unknown.</value>
        [DataMember(Name = "itunesPageUrl", EmitDefaultValue = true)]
        public string ItunesPageUrl { get; set; }

        /// <summary>
        /// The iTunes ID for the podcast. Will be null if unknown.
        /// </summary>
        /// <value>The iTunes ID for the podcast. Will be null if unknown.</value>
        [DataMember(Name = "itunesId", EmitDefaultValue = true)]
        public int? ItunesId { get; set; }

        /// <summary>
        /// The iTunes Artist ID for the author of the podcast. Will be null if unknown.
        /// </summary>
        /// <value>The iTunes Artist ID for the author of the podcast. Will be null if unknown.</value>
        [DataMember(Name = "itunesArtistId", EmitDefaultValue = true)]
        public int? ItunesArtistId { get; set; }

        /// <summary>
        /// Whether the podcast has been marked as explicit.
        /// </summary>
        /// <value>Whether the podcast has been marked as explicit.</value>
        [DataMember(Name = "explicit", EmitDefaultValue = true)]
        public bool Explicit { get; set; }

        /// <summary>
        /// The language of the podcast. Will be null if unknown.
        /// </summary>
        /// <value>The language of the podcast. Will be null if unknown.</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// The type of the podcast.
        /// </summary>
        /// <value>The type of the podcast.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PodcastMetadataModel {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  FeedUrl: ").Append(FeedUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ItunesPageUrl: ").Append(ItunesPageUrl).Append("\n");
            sb.Append("  ItunesId: ").Append(ItunesId).Append("\n");
            sb.Append("  ItunesArtistId: ").Append(ItunesArtistId).Append("\n");
            sb.Append("  Explicit: ").Append(Explicit).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
