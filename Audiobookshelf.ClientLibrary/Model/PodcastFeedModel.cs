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
    /// Podcast Feed
    /// </summary>
    [DataContract(Name = "PodcastFeed")]
    public partial class PodcastFeedModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastFeedModel" /> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="episodes">The podcast&#39;s episodes from the feed..</param>
        public PodcastFeedModel(PodcastFeedMetadataModel metadata = default(PodcastFeedMetadataModel), List<PodcastFeedEpisodeModel> episodes = default(List<PodcastFeedEpisodeModel>))
        {
            this.Metadata = metadata;
            this.Episodes = episodes;
        }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public PodcastFeedMetadataModel Metadata { get; set; }

        /// <summary>
        /// The podcast&#39;s episodes from the feed.
        /// </summary>
        /// <value>The podcast&#39;s episodes from the feed.</value>
        [DataMember(Name = "episodes", EmitDefaultValue = false)]
        public List<PodcastFeedEpisodeModel> Episodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PodcastFeedModel {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Episodes: ").Append(Episodes).Append("\n");
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
