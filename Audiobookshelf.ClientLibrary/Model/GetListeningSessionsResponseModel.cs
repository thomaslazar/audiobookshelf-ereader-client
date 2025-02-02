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
    /// GetListeningSessionsResponseModel
    /// </summary>
    [DataContract(Name = "GetListeningSessionsResponse")]
    public partial class GetListeningSessionsResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetListeningSessionsResponseModel" /> class.
        /// </summary>
        /// <param name="total">The total number of listening sessions..</param>
        /// <param name="numPages">The total number of pages..</param>
        /// <param name="itemsPerPage">The provided itemsPerPage parameter..</param>
        /// <param name="sessions">sessions.</param>
        public GetListeningSessionsResponseModel(int total = default(int), int numPages = default(int), int itemsPerPage = default(int), List<PlaybackSessionModel> sessions = default(List<PlaybackSessionModel>))
        {
            this.Total = total;
            this.NumPages = numPages;
            this.ItemsPerPage = itemsPerPage;
            this.Sessions = sessions;
        }

        /// <summary>
        /// The total number of listening sessions.
        /// </summary>
        /// <value>The total number of listening sessions.</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        /// <value>The total number of pages.</value>
        [DataMember(Name = "numPages", EmitDefaultValue = false)]
        public int NumPages { get; set; }

        /// <summary>
        /// The provided itemsPerPage parameter.
        /// </summary>
        /// <value>The provided itemsPerPage parameter.</value>
        [DataMember(Name = "itemsPerPage", EmitDefaultValue = false)]
        public int ItemsPerPage { get; set; }

        /// <summary>
        /// Gets or Sets Sessions
        /// </summary>
        [DataMember(Name = "sessions", EmitDefaultValue = false)]
        public List<PlaybackSessionModel> Sessions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetListeningSessionsResponseModel {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  NumPages: ").Append(NumPages).Append("\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
