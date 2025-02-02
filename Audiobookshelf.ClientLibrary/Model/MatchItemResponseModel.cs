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
    /// MatchItemResponseModel
    /// </summary>
    [DataContract(Name = "MatchItemResponse")]
    public partial class MatchItemResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchItemResponseModel" /> class.
        /// </summary>
        /// <param name="updated">updated.</param>
        /// <param name="libraryItem">libraryItem.</param>
        public MatchItemResponseModel(bool updated = default(bool), LibraryItemExpandedModel libraryItem = default(LibraryItemExpandedModel))
        {
            this.Updated = updated;
            this.LibraryItem = libraryItem;
        }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = true)]
        public bool Updated { get; set; }

        /// <summary>
        /// Gets or Sets LibraryItem
        /// </summary>
        [DataMember(Name = "libraryItem", EmitDefaultValue = false)]
        public LibraryItemExpandedModel LibraryItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchItemResponseModel {\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  LibraryItem: ").Append(LibraryItem).Append("\n");
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
