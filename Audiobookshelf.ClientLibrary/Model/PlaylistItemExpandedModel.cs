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
    /// An expanded playlist item.
    /// </summary>
    [DataContract(Name = "PlaylistItemExpanded")]
    public partial class PlaylistItemExpandedModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistItemExpandedModel" /> class.
        /// </summary>
        /// <param name="libraryItemId">The ID of the library item..</param>
        /// <param name="episodeId">The episode ID if it&#39;s a podcast episode..</param>
        /// <param name="libraryItem">libraryItem.</param>
        /// <param name="episode">episode.</param>
        public PlaylistItemExpandedModel(string libraryItemId = default(string), string episodeId = default(string), PlaylistItemExpandedLibraryItemModel libraryItem = default(PlaylistItemExpandedLibraryItemModel), PodcastEpisodeExpandedModel episode = default(PodcastEpisodeExpandedModel))
        {
            this.LibraryItemId = libraryItemId;
            this.EpisodeId = episodeId;
            this.LibraryItem = libraryItem;
            this.Episode = episode;
        }

        /// <summary>
        /// The ID of the library item.
        /// </summary>
        /// <value>The ID of the library item.</value>
        [DataMember(Name = "libraryItemId", EmitDefaultValue = false)]
        public string LibraryItemId { get; set; }

        /// <summary>
        /// The episode ID if it&#39;s a podcast episode.
        /// </summary>
        /// <value>The episode ID if it&#39;s a podcast episode.</value>
        [DataMember(Name = "episodeId", EmitDefaultValue = true)]
        public string EpisodeId { get; set; }

        /// <summary>
        /// Gets or Sets LibraryItem
        /// </summary>
        [DataMember(Name = "libraryItem", EmitDefaultValue = false)]
        public PlaylistItemExpandedLibraryItemModel LibraryItem { get; set; }

        /// <summary>
        /// Gets or Sets Episode
        /// </summary>
        [DataMember(Name = "episode", EmitDefaultValue = false)]
        public PodcastEpisodeExpandedModel Episode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlaylistItemExpandedModel {\n");
            sb.Append("  LibraryItemId: ").Append(LibraryItemId).Append("\n");
            sb.Append("  EpisodeId: ").Append(EpisodeId).Append("\n");
            sb.Append("  LibraryItem: ").Append(LibraryItem).Append("\n");
            sb.Append("  Episode: ").Append(Episode).Append("\n");
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