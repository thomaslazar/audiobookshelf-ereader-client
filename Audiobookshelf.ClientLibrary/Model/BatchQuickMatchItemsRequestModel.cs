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
    /// BatchQuickMatchItemsRequestModel
    /// </summary>
    [DataContract(Name = "BatchQuickMatchItemsRequest")]
    public partial class BatchQuickMatchItemsRequestModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchQuickMatchItemsRequestModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchQuickMatchItemsRequestModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchQuickMatchItemsRequestModel" /> class.
        /// </summary>
        /// <param name="options">options.</param>
        /// <param name="libraryItemIds">libraryItemIds (required).</param>
        public BatchQuickMatchItemsRequestModel(BatchQuickMatchItemsRequestOptionsModel options = default(BatchQuickMatchItemsRequestOptionsModel), List<string> libraryItemIds = default(List<string>))
        {
            // to ensure "libraryItemIds" is required (not null)
            if (libraryItemIds == null)
            {
                throw new ArgumentNullException("libraryItemIds is a required property for BatchQuickMatchItemsRequestModel and cannot be null");
            }
            this.LibraryItemIds = libraryItemIds;
            this.Options = options;
        }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public BatchQuickMatchItemsRequestOptionsModel Options { get; set; }

        /// <summary>
        /// Gets or Sets LibraryItemIds
        /// </summary>
        [DataMember(Name = "libraryItemIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> LibraryItemIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BatchQuickMatchItemsRequestModel {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  LibraryItemIds: ").Append(LibraryItemIds).Append("\n");
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
