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
    /// GetLibraryAuthorsResponseModel
    /// </summary>
    [DataContract(Name = "GetLibraryAuthorsResponse")]
    public partial class GetLibraryAuthorsResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLibraryAuthorsResponseModel" /> class.
        /// </summary>
        /// <param name="authors">authors.</param>
        public GetLibraryAuthorsResponseModel(List<AuthorExpandedModel> authors = default(List<AuthorExpandedModel>))
        {
            this.Authors = authors;
        }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public List<AuthorExpandedModel> Authors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetLibraryAuthorsResponseModel {\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
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
