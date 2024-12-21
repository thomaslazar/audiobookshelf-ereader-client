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
    /// GetAllUsersResponseModel
    /// </summary>
    [DataContract(Name = "GetAllUsersResponse")]
    public partial class GetAllUsersResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllUsersResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAllUsersResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllUsersResponseModel" /> class.
        /// </summary>
        /// <param name="users">users (required).</param>
        public GetAllUsersResponseModel(List<UserWithProgressDetailsModel> users = default(List<UserWithProgressDetailsModel>))
        {
            // to ensure "users" is required (not null)
            if (users == null)
            {
                throw new ArgumentNullException("users is a required property for GetAllUsersResponseModel and cannot be null");
            }
            this.Users = users;
        }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", IsRequired = true, EmitDefaultValue = true)]
        public List<UserWithProgressDetailsModel> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllUsersResponseModel {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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