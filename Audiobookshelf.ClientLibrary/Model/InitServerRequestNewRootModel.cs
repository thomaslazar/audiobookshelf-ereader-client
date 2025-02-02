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
    /// InitServerRequestNewRootModel
    /// </summary>
    [DataContract(Name = "InitServerRequest_newRoot")]
    public partial class InitServerRequestNewRootModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitServerRequestNewRootModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitServerRequestNewRootModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitServerRequestNewRootModel" /> class.
        /// </summary>
        /// <param name="username">The username of the new root user (required).</param>
        /// <param name="password">The password of the new root user (may be empty).</param>
        public InitServerRequestNewRootModel(string username = default(string), string password = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for InitServerRequestNewRootModel and cannot be null");
            }
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// The username of the new root user
        /// </summary>
        /// <value>The username of the new root user</value>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// The password of the new root user (may be empty)
        /// </summary>
        /// <value>The password of the new root user (may be empty)</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InitServerRequestNewRootModel {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
