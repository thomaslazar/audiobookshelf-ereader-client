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
    /// Stream Progress
    /// </summary>
    [DataContract(Name = "StreamProgress")]
    public partial class StreamProgressModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamProgressModel" /> class.
        /// </summary>
        /// <param name="stream">The ID of the stream..</param>
        /// <param name="percent">A human-readable percentage of transcode completion..</param>
        /// <param name="chunks">The segment ranges transcoded..</param>
        /// <param name="numSegments">The total number of segments..</param>
        public StreamProgressModel(string stream = default(string), string percent = default(string), List<string> chunks = default(List<string>), int numSegments = default(int))
        {
            this.Stream = stream;
            this.Percent = percent;
            this.Chunks = chunks;
            this.NumSegments = numSegments;
        }

        /// <summary>
        /// The ID of the stream.
        /// </summary>
        /// <value>The ID of the stream.</value>
        [DataMember(Name = "stream", EmitDefaultValue = false)]
        public string Stream { get; set; }

        /// <summary>
        /// A human-readable percentage of transcode completion.
        /// </summary>
        /// <value>A human-readable percentage of transcode completion.</value>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public string Percent { get; set; }

        /// <summary>
        /// The segment ranges transcoded.
        /// </summary>
        /// <value>The segment ranges transcoded.</value>
        [DataMember(Name = "chunks", EmitDefaultValue = false)]
        public List<string> Chunks { get; set; }

        /// <summary>
        /// The total number of segments.
        /// </summary>
        /// <value>The total number of segments.</value>
        [DataMember(Name = "numSegments", EmitDefaultValue = false)]
        public int NumSegments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StreamProgressModel {\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Chunks: ").Append(Chunks).Append("\n");
            sb.Append("  NumSegments: ").Append(NumSegments).Append("\n");
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
