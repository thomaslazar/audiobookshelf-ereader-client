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
    /// Expanded Book Metadata.
    /// </summary>
    [DataContract(Name = "BookMetadataExpanded")]
    public partial class BookMetadataExpandedModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookMetadataExpandedModel" /> class.
        /// </summary>
        /// <param name="titleIgnorePrefix">The title of the book with any prefix moved to the end..</param>
        /// <param name="authorName">The name of the book&#39;s author(s)..</param>
        /// <param name="authorNameLF">The author&#39;s name with last names first..</param>
        /// <param name="narratorName">The narrator&#39;s name..</param>
        /// <param name="seriesName">The series name..</param>
        /// <param name="title">The title of the book. Will be null if unknown..</param>
        /// <param name="subtitle">The subtitle of the book. Will be null if there is no subtitle..</param>
        /// <param name="authors">The authors of the book..</param>
        /// <param name="narrators">The narrators of the audiobook..</param>
        /// <param name="series">The series the book belongs to..</param>
        /// <param name="genres">The genres of the book..</param>
        /// <param name="publishedYear">The year the book was published. Will be null if unknown..</param>
        /// <param name="publishedDate">The date the book was published. Will be null if unknown..</param>
        /// <param name="publisher">The publisher of the book. Will be null if unknown..</param>
        /// <param name="description">A description for the book. Will be null if empty..</param>
        /// <param name="isbn">The ISBN of the book. Will be null if unknown..</param>
        /// <param name="asin">The ASIN of the book. Will be null if unknown..</param>
        /// <param name="language">The language of the book. Will be null if unknown..</param>
        /// <param name="varExplicit">Whether the book has been marked as explicit..</param>
        /// <param name="abridged">Whether the book is abridged..</param>
        public BookMetadataExpandedModel(string titleIgnorePrefix = default(string), string authorName = default(string), string authorNameLF = default(string), string narratorName = default(string), string seriesName = default(string), string title = default(string), string subtitle = default(string), List<AuthorMinifiedModel> authors = default(List<AuthorMinifiedModel>), List<string> narrators = default(List<string>), List<SeriesSequenceModel> series = default(List<SeriesSequenceModel>), List<string> genres = default(List<string>), string publishedYear = default(string), string publishedDate = default(string), string publisher = default(string), string description = default(string), string isbn = default(string), string asin = default(string), string language = default(string), bool varExplicit = default(bool), bool abridged = default(bool))
        {
            this.TitleIgnorePrefix = titleIgnorePrefix;
            this.AuthorName = authorName;
            this.AuthorNameLF = authorNameLF;
            this.NarratorName = narratorName;
            this.SeriesName = seriesName;
            this.Title = title;
            this.Subtitle = subtitle;
            this.Authors = authors;
            this.Narrators = narrators;
            this.Series = series;
            this.Genres = genres;
            this.PublishedYear = publishedYear;
            this.PublishedDate = publishedDate;
            this.Publisher = publisher;
            this.Description = description;
            this.Isbn = isbn;
            this.Asin = asin;
            this.Language = language;
            this.Explicit = varExplicit;
            this.Abridged = abridged;
        }

        /// <summary>
        /// The title of the book with any prefix moved to the end.
        /// </summary>
        /// <value>The title of the book with any prefix moved to the end.</value>
        [DataMember(Name = "titleIgnorePrefix", EmitDefaultValue = false)]
        public string TitleIgnorePrefix { get; set; }

        /// <summary>
        /// The name of the book&#39;s author(s).
        /// </summary>
        /// <value>The name of the book&#39;s author(s).</value>
        [DataMember(Name = "authorName", EmitDefaultValue = true)]
        public string AuthorName { get; set; }

        /// <summary>
        /// The author&#39;s name with last names first.
        /// </summary>
        /// <value>The author&#39;s name with last names first.</value>
        [DataMember(Name = "authorNameLF", EmitDefaultValue = true)]
        public string AuthorNameLF { get; set; }

        /// <summary>
        /// The narrator&#39;s name.
        /// </summary>
        /// <value>The narrator&#39;s name.</value>
        [DataMember(Name = "narratorName", EmitDefaultValue = true)]
        public string NarratorName { get; set; }

        /// <summary>
        /// The series name.
        /// </summary>
        /// <value>The series name.</value>
        [DataMember(Name = "seriesName", EmitDefaultValue = true)]
        public string SeriesName { get; set; }

        /// <summary>
        /// The title of the book. Will be null if unknown.
        /// </summary>
        /// <value>The title of the book. Will be null if unknown.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The subtitle of the book. Will be null if there is no subtitle.
        /// </summary>
        /// <value>The subtitle of the book. Will be null if there is no subtitle.</value>
        [DataMember(Name = "subtitle", EmitDefaultValue = true)]
        public string Subtitle { get; set; }

        /// <summary>
        /// The authors of the book.
        /// </summary>
        /// <value>The authors of the book.</value>
        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public List<AuthorMinifiedModel> Authors { get; set; }

        /// <summary>
        /// The narrators of the audiobook.
        /// </summary>
        /// <value>The narrators of the audiobook.</value>
        [DataMember(Name = "narrators", EmitDefaultValue = false)]
        public List<string> Narrators { get; set; }

        /// <summary>
        /// The series the book belongs to.
        /// </summary>
        /// <value>The series the book belongs to.</value>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        public List<SeriesSequenceModel> Series { get; set; }

        /// <summary>
        /// The genres of the book.
        /// </summary>
        /// <value>The genres of the book.</value>
        [DataMember(Name = "genres", EmitDefaultValue = false)]
        public List<string> Genres { get; set; }

        /// <summary>
        /// The year the book was published. Will be null if unknown.
        /// </summary>
        /// <value>The year the book was published. Will be null if unknown.</value>
        [DataMember(Name = "publishedYear", EmitDefaultValue = true)]
        public string PublishedYear { get; set; }

        /// <summary>
        /// The date the book was published. Will be null if unknown.
        /// </summary>
        /// <value>The date the book was published. Will be null if unknown.</value>
        [DataMember(Name = "publishedDate", EmitDefaultValue = true)]
        public string PublishedDate { get; set; }

        /// <summary>
        /// The publisher of the book. Will be null if unknown.
        /// </summary>
        /// <value>The publisher of the book. Will be null if unknown.</value>
        [DataMember(Name = "publisher", EmitDefaultValue = true)]
        public string Publisher { get; set; }

        /// <summary>
        /// A description for the book. Will be null if empty.
        /// </summary>
        /// <value>A description for the book. Will be null if empty.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The ISBN of the book. Will be null if unknown.
        /// </summary>
        /// <value>The ISBN of the book. Will be null if unknown.</value>
        [DataMember(Name = "isbn", EmitDefaultValue = true)]
        public string Isbn { get; set; }

        /// <summary>
        /// The ASIN of the book. Will be null if unknown.
        /// </summary>
        /// <value>The ASIN of the book. Will be null if unknown.</value>
        [DataMember(Name = "asin", EmitDefaultValue = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The language of the book. Will be null if unknown.
        /// </summary>
        /// <value>The language of the book. Will be null if unknown.</value>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Whether the book has been marked as explicit.
        /// </summary>
        /// <value>Whether the book has been marked as explicit.</value>
        [DataMember(Name = "explicit", EmitDefaultValue = true)]
        public bool Explicit { get; set; }

        /// <summary>
        /// Whether the book is abridged.
        /// </summary>
        /// <value>Whether the book is abridged.</value>
        [DataMember(Name = "abridged", EmitDefaultValue = true)]
        public bool Abridged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BookMetadataExpandedModel {\n");
            sb.Append("  TitleIgnorePrefix: ").Append(TitleIgnorePrefix).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AuthorNameLF: ").Append(AuthorNameLF).Append("\n");
            sb.Append("  NarratorName: ").Append(NarratorName).Append("\n");
            sb.Append("  SeriesName: ").Append(SeriesName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  Narrators: ").Append(Narrators).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  PublishedYear: ").Append(PublishedYear).Append("\n");
            sb.Append("  PublishedDate: ").Append(PublishedDate).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Isbn: ").Append(Isbn).Append("\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Explicit: ").Append(Explicit).Append("\n");
            sb.Append("  Abridged: ").Append(Abridged).Append("\n");
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
