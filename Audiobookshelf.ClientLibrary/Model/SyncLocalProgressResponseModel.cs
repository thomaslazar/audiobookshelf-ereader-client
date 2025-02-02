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
    /// SyncLocalProgressResponseModel
    /// </summary>
    [DataContract(Name = "SyncLocalProgressResponse")]
    public partial class SyncLocalProgressResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncLocalProgressResponseModel" /> class.
        /// </summary>
        /// <param name="numServerProgressUpdates">The number of media progress items that were updated on the server..</param>
        /// <param name="localProgressUpdates">Local media progress items with updated information from the server (server more recent)..</param>
        /// <param name="serverProgressUpdates">Media progress items that were updated on the server (local more recent)..</param>
        public SyncLocalProgressResponseModel(int numServerProgressUpdates = default(int), List<MediaProgressModel> localProgressUpdates = default(List<MediaProgressModel>), List<MediaProgressModel> serverProgressUpdates = default(List<MediaProgressModel>))
        {
            this.NumServerProgressUpdates = numServerProgressUpdates;
            this.LocalProgressUpdates = localProgressUpdates;
            this.ServerProgressUpdates = serverProgressUpdates;
        }

        /// <summary>
        /// The number of media progress items that were updated on the server.
        /// </summary>
        /// <value>The number of media progress items that were updated on the server.</value>
        [DataMember(Name = "numServerProgressUpdates", EmitDefaultValue = false)]
        public int NumServerProgressUpdates { get; set; }

        /// <summary>
        /// Local media progress items with updated information from the server (server more recent).
        /// </summary>
        /// <value>Local media progress items with updated information from the server (server more recent).</value>
        [DataMember(Name = "localProgressUpdates", EmitDefaultValue = false)]
        public List<MediaProgressModel> LocalProgressUpdates { get; set; }

        /// <summary>
        /// Media progress items that were updated on the server (local more recent).
        /// </summary>
        /// <value>Media progress items that were updated on the server (local more recent).</value>
        [DataMember(Name = "serverProgressUpdates", EmitDefaultValue = false)]
        public List<MediaProgressModel> ServerProgressUpdates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SyncLocalProgressResponseModel {\n");
            sb.Append("  NumServerProgressUpdates: ").Append(NumServerProgressUpdates).Append("\n");
            sb.Append("  LocalProgressUpdates: ").Append(LocalProgressUpdates).Append("\n");
            sb.Append("  ServerProgressUpdates: ").Append(ServerProgressUpdates).Append("\n");
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
