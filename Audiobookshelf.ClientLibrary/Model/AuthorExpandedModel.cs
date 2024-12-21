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
    /// Expanded author.
    /// </summary>
    [DataContract(Name = "AuthorExpanded")]
    public partial class AuthorExpandedModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorExpandedModel" /> class.
        /// </summary>
        /// <param name="numBooks">The number of books associated with the author in the library..</param>
        /// <param name="id">The ID of the author..</param>
        /// <param name="asin">The ASIN of the author. Will be null if unknown..</param>
        /// <param name="name">The name of the author..</param>
        /// <param name="description">A description of the author. Will be null if there is none..</param>
        /// <param name="imagePath">The absolute path for the author image. Will be null if there is no image..</param>
        /// <param name="addedAt">The time (in ms since POSIX epoch) when the author was added..</param>
        /// <param name="updatedAt">The time (in ms since POSIX epoch) when the author was last updated..</param>
        public AuthorExpandedModel(int numBooks = default(int), string id = default(string), string asin = default(string), string name = default(string), string description = default(string), string imagePath = default(string), long addedAt = default(long), long updatedAt = default(long))
        {
            this.NumBooks = numBooks;
            this.Id = id;
            this.Asin = asin;
            this.Name = name;
            this.Description = description;
            this.ImagePath = imagePath;
            this.AddedAt = addedAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The number of books associated with the author in the library.
        /// </summary>
        /// <value>The number of books associated with the author in the library.</value>
        [DataMember(Name = "numBooks", EmitDefaultValue = false)]
        public int NumBooks { get; set; }

        /// <summary>
        /// The ID of the author.
        /// </summary>
        /// <value>The ID of the author.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The ASIN of the author. Will be null if unknown.
        /// </summary>
        /// <value>The ASIN of the author. Will be null if unknown.</value>
        [DataMember(Name = "asin", EmitDefaultValue = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The name of the author.
        /// </summary>
        /// <value>The name of the author.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the author. Will be null if there is none.
        /// </summary>
        /// <value>A description of the author. Will be null if there is none.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The absolute path for the author image. Will be null if there is no image.
        /// </summary>
        /// <value>The absolute path for the author image. Will be null if there is no image.</value>
        [DataMember(Name = "imagePath", EmitDefaultValue = true)]
        public string ImagePath { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the author was added.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the author was added.</value>
        [DataMember(Name = "addedAt", EmitDefaultValue = false)]
        public long AddedAt { get; set; }

        /// <summary>
        /// The time (in ms since POSIX epoch) when the author was last updated.
        /// </summary>
        /// <value>The time (in ms since POSIX epoch) when the author was last updated.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorExpandedModel {\n");
            sb.Append("  NumBooks: ").Append(NumBooks).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  AddedAt: ").Append(AddedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
