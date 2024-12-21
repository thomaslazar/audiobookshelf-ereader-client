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
    /// ID3 metadata tags pulled from the audio file on import. Only non-null tags will be returned in requests.
    /// </summary>
    [DataContract(Name = "AudioMetaTags")]
    public partial class AudioMetaTagsModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioMetaTagsModel" /> class.
        /// </summary>
        /// <param name="tagAlbum">tagAlbum.</param>
        /// <param name="tagArtist">tagArtist.</param>
        /// <param name="tagGenre">tagGenre.</param>
        /// <param name="tagTitle">tagTitle.</param>
        /// <param name="tagSeries">tagSeries.</param>
        /// <param name="tagSeriesPart">tagSeriesPart.</param>
        /// <param name="tagTrack">tagTrack.</param>
        /// <param name="tagDisc">tagDisc.</param>
        /// <param name="tagSubtitle">tagSubtitle.</param>
        /// <param name="tagAlbumArtist">tagAlbumArtist.</param>
        /// <param name="tagDate">tagDate.</param>
        /// <param name="tagComposer">tagComposer.</param>
        /// <param name="tagPublisher">tagPublisher.</param>
        /// <param name="tagComment">tagComment.</param>
        /// <param name="tagDescription">tagDescription.</param>
        /// <param name="tagEncoder">tagEncoder.</param>
        /// <param name="tagEncodedBy">tagEncodedBy.</param>
        /// <param name="tagIsbn">tagIsbn.</param>
        /// <param name="tagLanguage">tagLanguage.</param>
        /// <param name="tagASIN">tagASIN.</param>
        /// <param name="tagOverdriveMediaMarker">tagOverdriveMediaMarker.</param>
        /// <param name="tagOriginalYear">tagOriginalYear.</param>
        /// <param name="tagReleaseCountry">tagReleaseCountry.</param>
        /// <param name="tagReleaseType">tagReleaseType.</param>
        /// <param name="tagReleaseStatus">tagReleaseStatus.</param>
        /// <param name="tagISRC">tagISRC.</param>
        /// <param name="tagMusicBrainzTrackId">tagMusicBrainzTrackId.</param>
        /// <param name="tagMusicBrainzAlbumId">tagMusicBrainzAlbumId.</param>
        /// <param name="tagMusicBrainzAlbumArtistId">tagMusicBrainzAlbumArtistId.</param>
        /// <param name="tagMusicBrainzArtistId">tagMusicBrainzArtistId.</param>
        public AudioMetaTagsModel(string tagAlbum = default(string), string tagArtist = default(string), string tagGenre = default(string), string tagTitle = default(string), string tagSeries = default(string), string tagSeriesPart = default(string), string tagTrack = default(string), string tagDisc = default(string), string tagSubtitle = default(string), string tagAlbumArtist = default(string), string tagDate = default(string), string tagComposer = default(string), string tagPublisher = default(string), string tagComment = default(string), string tagDescription = default(string), string tagEncoder = default(string), string tagEncodedBy = default(string), string tagIsbn = default(string), string tagLanguage = default(string), string tagASIN = default(string), string tagOverdriveMediaMarker = default(string), string tagOriginalYear = default(string), string tagReleaseCountry = default(string), string tagReleaseType = default(string), string tagReleaseStatus = default(string), string tagISRC = default(string), string tagMusicBrainzTrackId = default(string), string tagMusicBrainzAlbumId = default(string), string tagMusicBrainzAlbumArtistId = default(string), string tagMusicBrainzArtistId = default(string))
        {
            this.TagAlbum = tagAlbum;
            this.TagArtist = tagArtist;
            this.TagGenre = tagGenre;
            this.TagTitle = tagTitle;
            this.TagSeries = tagSeries;
            this.TagSeriesPart = tagSeriesPart;
            this.TagTrack = tagTrack;
            this.TagDisc = tagDisc;
            this.TagSubtitle = tagSubtitle;
            this.TagAlbumArtist = tagAlbumArtist;
            this.TagDate = tagDate;
            this.TagComposer = tagComposer;
            this.TagPublisher = tagPublisher;
            this.TagComment = tagComment;
            this.TagDescription = tagDescription;
            this.TagEncoder = tagEncoder;
            this.TagEncodedBy = tagEncodedBy;
            this.TagIsbn = tagIsbn;
            this.TagLanguage = tagLanguage;
            this.TagASIN = tagASIN;
            this.TagOverdriveMediaMarker = tagOverdriveMediaMarker;
            this.TagOriginalYear = tagOriginalYear;
            this.TagReleaseCountry = tagReleaseCountry;
            this.TagReleaseType = tagReleaseType;
            this.TagReleaseStatus = tagReleaseStatus;
            this.TagISRC = tagISRC;
            this.TagMusicBrainzTrackId = tagMusicBrainzTrackId;
            this.TagMusicBrainzAlbumId = tagMusicBrainzAlbumId;
            this.TagMusicBrainzAlbumArtistId = tagMusicBrainzAlbumArtistId;
            this.TagMusicBrainzArtistId = tagMusicBrainzArtistId;
        }

        /// <summary>
        /// Gets or Sets TagAlbum
        /// </summary>
        [DataMember(Name = "tagAlbum", EmitDefaultValue = true)]
        public string TagAlbum { get; set; }

        /// <summary>
        /// Gets or Sets TagArtist
        /// </summary>
        [DataMember(Name = "tagArtist", EmitDefaultValue = true)]
        public string TagArtist { get; set; }

        /// <summary>
        /// Gets or Sets TagGenre
        /// </summary>
        [DataMember(Name = "tagGenre", EmitDefaultValue = true)]
        public string TagGenre { get; set; }

        /// <summary>
        /// Gets or Sets TagTitle
        /// </summary>
        [DataMember(Name = "tagTitle", EmitDefaultValue = true)]
        public string TagTitle { get; set; }

        /// <summary>
        /// Gets or Sets TagSeries
        /// </summary>
        [DataMember(Name = "tagSeries", EmitDefaultValue = true)]
        public string TagSeries { get; set; }

        /// <summary>
        /// Gets or Sets TagSeriesPart
        /// </summary>
        [DataMember(Name = "tagSeriesPart", EmitDefaultValue = true)]
        public string TagSeriesPart { get; set; }

        /// <summary>
        /// Gets or Sets TagTrack
        /// </summary>
        [DataMember(Name = "tagTrack", EmitDefaultValue = true)]
        public string TagTrack { get; set; }

        /// <summary>
        /// Gets or Sets TagDisc
        /// </summary>
        [DataMember(Name = "tagDisc", EmitDefaultValue = true)]
        public string TagDisc { get; set; }

        /// <summary>
        /// Gets or Sets TagSubtitle
        /// </summary>
        [DataMember(Name = "tagSubtitle", EmitDefaultValue = true)]
        public string TagSubtitle { get; set; }

        /// <summary>
        /// Gets or Sets TagAlbumArtist
        /// </summary>
        [DataMember(Name = "tagAlbumArtist", EmitDefaultValue = true)]
        public string TagAlbumArtist { get; set; }

        /// <summary>
        /// Gets or Sets TagDate
        /// </summary>
        [DataMember(Name = "tagDate", EmitDefaultValue = true)]
        public string TagDate { get; set; }

        /// <summary>
        /// Gets or Sets TagComposer
        /// </summary>
        [DataMember(Name = "tagComposer", EmitDefaultValue = true)]
        public string TagComposer { get; set; }

        /// <summary>
        /// Gets or Sets TagPublisher
        /// </summary>
        [DataMember(Name = "tagPublisher", EmitDefaultValue = true)]
        public string TagPublisher { get; set; }

        /// <summary>
        /// Gets or Sets TagComment
        /// </summary>
        [DataMember(Name = "tagComment", EmitDefaultValue = true)]
        public string TagComment { get; set; }

        /// <summary>
        /// Gets or Sets TagDescription
        /// </summary>
        [DataMember(Name = "tagDescription", EmitDefaultValue = true)]
        public string TagDescription { get; set; }

        /// <summary>
        /// Gets or Sets TagEncoder
        /// </summary>
        [DataMember(Name = "tagEncoder", EmitDefaultValue = true)]
        public string TagEncoder { get; set; }

        /// <summary>
        /// Gets or Sets TagEncodedBy
        /// </summary>
        [DataMember(Name = "tagEncodedBy", EmitDefaultValue = true)]
        public string TagEncodedBy { get; set; }

        /// <summary>
        /// Gets or Sets TagIsbn
        /// </summary>
        [DataMember(Name = "tagIsbn", EmitDefaultValue = true)]
        public string TagIsbn { get; set; }

        /// <summary>
        /// Gets or Sets TagLanguage
        /// </summary>
        [DataMember(Name = "tagLanguage", EmitDefaultValue = true)]
        public string TagLanguage { get; set; }

        /// <summary>
        /// Gets or Sets TagASIN
        /// </summary>
        [DataMember(Name = "tagASIN", EmitDefaultValue = true)]
        public string TagASIN { get; set; }

        /// <summary>
        /// Gets or Sets TagOverdriveMediaMarker
        /// </summary>
        [DataMember(Name = "tagOverdriveMediaMarker", EmitDefaultValue = true)]
        public string TagOverdriveMediaMarker { get; set; }

        /// <summary>
        /// Gets or Sets TagOriginalYear
        /// </summary>
        [DataMember(Name = "tagOriginalYear", EmitDefaultValue = true)]
        public string TagOriginalYear { get; set; }

        /// <summary>
        /// Gets or Sets TagReleaseCountry
        /// </summary>
        [DataMember(Name = "tagReleaseCountry", EmitDefaultValue = true)]
        public string TagReleaseCountry { get; set; }

        /// <summary>
        /// Gets or Sets TagReleaseType
        /// </summary>
        [DataMember(Name = "tagReleaseType", EmitDefaultValue = true)]
        public string TagReleaseType { get; set; }

        /// <summary>
        /// Gets or Sets TagReleaseStatus
        /// </summary>
        [DataMember(Name = "tagReleaseStatus", EmitDefaultValue = true)]
        public string TagReleaseStatus { get; set; }

        /// <summary>
        /// Gets or Sets TagISRC
        /// </summary>
        [DataMember(Name = "tagISRC", EmitDefaultValue = true)]
        public string TagISRC { get; set; }

        /// <summary>
        /// Gets or Sets TagMusicBrainzTrackId
        /// </summary>
        [DataMember(Name = "tagMusicBrainzTrackId", EmitDefaultValue = true)]
        public string TagMusicBrainzTrackId { get; set; }

        /// <summary>
        /// Gets or Sets TagMusicBrainzAlbumId
        /// </summary>
        [DataMember(Name = "tagMusicBrainzAlbumId", EmitDefaultValue = true)]
        public string TagMusicBrainzAlbumId { get; set; }

        /// <summary>
        /// Gets or Sets TagMusicBrainzAlbumArtistId
        /// </summary>
        [DataMember(Name = "tagMusicBrainzAlbumArtistId", EmitDefaultValue = true)]
        public string TagMusicBrainzAlbumArtistId { get; set; }

        /// <summary>
        /// Gets or Sets TagMusicBrainzArtistId
        /// </summary>
        [DataMember(Name = "tagMusicBrainzArtistId", EmitDefaultValue = true)]
        public string TagMusicBrainzArtistId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AudioMetaTagsModel {\n");
            sb.Append("  TagAlbum: ").Append(TagAlbum).Append("\n");
            sb.Append("  TagArtist: ").Append(TagArtist).Append("\n");
            sb.Append("  TagGenre: ").Append(TagGenre).Append("\n");
            sb.Append("  TagTitle: ").Append(TagTitle).Append("\n");
            sb.Append("  TagSeries: ").Append(TagSeries).Append("\n");
            sb.Append("  TagSeriesPart: ").Append(TagSeriesPart).Append("\n");
            sb.Append("  TagTrack: ").Append(TagTrack).Append("\n");
            sb.Append("  TagDisc: ").Append(TagDisc).Append("\n");
            sb.Append("  TagSubtitle: ").Append(TagSubtitle).Append("\n");
            sb.Append("  TagAlbumArtist: ").Append(TagAlbumArtist).Append("\n");
            sb.Append("  TagDate: ").Append(TagDate).Append("\n");
            sb.Append("  TagComposer: ").Append(TagComposer).Append("\n");
            sb.Append("  TagPublisher: ").Append(TagPublisher).Append("\n");
            sb.Append("  TagComment: ").Append(TagComment).Append("\n");
            sb.Append("  TagDescription: ").Append(TagDescription).Append("\n");
            sb.Append("  TagEncoder: ").Append(TagEncoder).Append("\n");
            sb.Append("  TagEncodedBy: ").Append(TagEncodedBy).Append("\n");
            sb.Append("  TagIsbn: ").Append(TagIsbn).Append("\n");
            sb.Append("  TagLanguage: ").Append(TagLanguage).Append("\n");
            sb.Append("  TagASIN: ").Append(TagASIN).Append("\n");
            sb.Append("  TagOverdriveMediaMarker: ").Append(TagOverdriveMediaMarker).Append("\n");
            sb.Append("  TagOriginalYear: ").Append(TagOriginalYear).Append("\n");
            sb.Append("  TagReleaseCountry: ").Append(TagReleaseCountry).Append("\n");
            sb.Append("  TagReleaseType: ").Append(TagReleaseType).Append("\n");
            sb.Append("  TagReleaseStatus: ").Append(TagReleaseStatus).Append("\n");
            sb.Append("  TagISRC: ").Append(TagISRC).Append("\n");
            sb.Append("  TagMusicBrainzTrackId: ").Append(TagMusicBrainzTrackId).Append("\n");
            sb.Append("  TagMusicBrainzAlbumId: ").Append(TagMusicBrainzAlbumId).Append("\n");
            sb.Append("  TagMusicBrainzAlbumArtistId: ").Append(TagMusicBrainzAlbumArtistId).Append("\n");
            sb.Append("  TagMusicBrainzArtistId: ").Append(TagMusicBrainzArtistId).Append("\n");
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
