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
    /// UpdateBookmarkRequestModel
    /// </summary>
    [DataContract(Name = "UpdateBookmarkRequest")]
    public partial class UpdateBookmarkRequestModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBookmarkRequestModel" /> class.
        /// </summary>
        /// <param name="time">The time (in seconds) of the bookmark..</param>
        /// <param name="title">The title of the bookmark..</param>
        public UpdateBookmarkRequestModel(int time = default(int), string title = default(string))
        {
            this.Time = time;
            this.Title = title;
        }

        /// <summary>
        /// The time (in seconds) of the bookmark.
        /// </summary>
        /// <value>The time (in seconds) of the bookmark.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public int Time { get; set; }

        /// <summary>
        /// The title of the bookmark.
        /// </summary>
        /// <value>The title of the bookmark.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateBookmarkRequestModel {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
