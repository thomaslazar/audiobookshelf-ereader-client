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
using System.Reflection;

namespace Audiobookshelf.ClientLibrary.Model
{
    /// <summary>
    /// The library item. Will be Library Item Minified if episodeId is not null.
    /// </summary>
    [JsonConverter(typeof(PlaylistItemExpandedLibraryItemModelJsonConverter))]
    [DataContract(Name = "PlaylistItemExpanded_libraryItem")]
    public partial class PlaylistItemExpandedLibraryItemModel : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistItemExpandedLibraryItemModel" /> class
        /// with the <see cref="LibraryItemExpandedModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LibraryItemExpandedModel.</param>
        public PlaylistItemExpandedLibraryItemModel(LibraryItemExpandedModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistItemExpandedLibraryItemModel" /> class
        /// with the <see cref="LibraryItemMinifiedModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LibraryItemMinifiedModel.</param>
        public PlaylistItemExpandedLibraryItemModel(LibraryItemMinifiedModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(LibraryItemExpandedModel) || value is LibraryItemExpandedModel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LibraryItemMinifiedModel) || value is LibraryItemMinifiedModel)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: LibraryItemExpandedModel, LibraryItemMinifiedModel");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `LibraryItemExpandedModel`. If the actual instance is not `LibraryItemExpandedModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LibraryItemExpandedModel</returns>
        public LibraryItemExpandedModel GetLibraryItemExpandedModel()
        {
            return (LibraryItemExpandedModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LibraryItemMinifiedModel`. If the actual instance is not `LibraryItemMinifiedModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LibraryItemMinifiedModel</returns>
        public LibraryItemMinifiedModel GetLibraryItemMinifiedModel()
        {
            return (LibraryItemMinifiedModel)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlaylistItemExpandedLibraryItemModel {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, PlaylistItemExpandedLibraryItemModel.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PlaylistItemExpandedLibraryItemModel
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PlaylistItemExpandedLibraryItemModel</returns>
        public static PlaylistItemExpandedLibraryItemModel FromJson(string jsonString)
        {
            PlaylistItemExpandedLibraryItemModel newPlaylistItemExpandedLibraryItemModel = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPlaylistItemExpandedLibraryItemModel;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LibraryItemExpandedModel).GetProperty("AdditionalProperties") == null)
                {
                    newPlaylistItemExpandedLibraryItemModel = new PlaylistItemExpandedLibraryItemModel(JsonConvert.DeserializeObject<LibraryItemExpandedModel>(jsonString, PlaylistItemExpandedLibraryItemModel.SerializerSettings));
                }
                else
                {
                    newPlaylistItemExpandedLibraryItemModel = new PlaylistItemExpandedLibraryItemModel(JsonConvert.DeserializeObject<LibraryItemExpandedModel>(jsonString, PlaylistItemExpandedLibraryItemModel.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LibraryItemExpandedModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LibraryItemExpandedModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LibraryItemMinifiedModel).GetProperty("AdditionalProperties") == null)
                {
                    newPlaylistItemExpandedLibraryItemModel = new PlaylistItemExpandedLibraryItemModel(JsonConvert.DeserializeObject<LibraryItemMinifiedModel>(jsonString, PlaylistItemExpandedLibraryItemModel.SerializerSettings));
                }
                else
                {
                    newPlaylistItemExpandedLibraryItemModel = new PlaylistItemExpandedLibraryItemModel(JsonConvert.DeserializeObject<LibraryItemMinifiedModel>(jsonString, PlaylistItemExpandedLibraryItemModel.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LibraryItemMinifiedModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LibraryItemMinifiedModel: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newPlaylistItemExpandedLibraryItemModel;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for PlaylistItemExpandedLibraryItemModel
    /// </summary>
    public class PlaylistItemExpandedLibraryItemModelJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PlaylistItemExpandedLibraryItemModel).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return PlaylistItemExpandedLibraryItemModel.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return PlaylistItemExpandedLibraryItemModel.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
