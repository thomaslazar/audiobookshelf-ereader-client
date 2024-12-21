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
    /// ChangePasswordResponseModel
    /// </summary>
    [DataContract(Name = "ChangePasswordResponse")]
    public partial class ChangePasswordResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordResponseModel" /> class.
        /// </summary>
        /// <param name="success">Will only exist and be true if the password was updated successfully..</param>
        /// <param name="error">The error that occurred. Will only exist if there was an error updating your password..</param>
        public ChangePasswordResponseModel(bool success = default(bool), string error = default(string))
        {
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// Will only exist and be true if the password was updated successfully.
        /// </summary>
        /// <value>Will only exist and be true if the password was updated successfully.</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// The error that occurred. Will only exist if there was an error updating your password.
        /// </summary>
        /// <value>The error that occurred. Will only exist if there was an error updating your password.</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChangePasswordResponseModel {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
