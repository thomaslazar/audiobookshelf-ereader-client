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
    /// SearchLibraryResponseModel
    /// </summary>
    [DataContract(Name = "SearchLibraryResponse")]
    public partial class SearchLibraryResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchLibraryResponseModel" /> class.
        /// </summary>
        /// <param name="book">book.</param>
        /// <param name="tags">tags.</param>
        /// <param name="authors">authors.</param>
        /// <param name="series">series.</param>
        public SearchLibraryResponseModel(List<LibraryItemSearchResultModel> book = default(List<LibraryItemSearchResultModel>), List<string> tags = default(List<string>), List<AuthorExpandedModel> authors = default(List<AuthorExpandedModel>), List<SeriesBooksModel> series = default(List<SeriesBooksModel>))
        {
            this.Book = book;
            this.Tags = tags;
            this.Authors = authors;
            this.Series = series;
        }

        /// <summary>
        /// Gets or Sets Book
        /// </summary>
        [DataMember(Name = "book", EmitDefaultValue = false)]
        public List<LibraryItemSearchResultModel> Book { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public List<AuthorExpandedModel> Authors { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        public List<SeriesBooksModel> Series { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchLibraryResponseModel {\n");
            sb.Append("  Book: ").Append(Book).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
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
