
#nullable enable

namespace Predibase
{
    /// <summary>
    /// A training dataset.
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// Unique identifier for the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Name of the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Processing status of the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Predibase.JsonConverters.DatasetStatusJsonConverter))]
        public global::Predibase.DatasetStatus? Status { get; set; }

        /// <summary>
        /// Number of rows in the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        /// Number of columns in the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_count")]
        public int? ColumnCount { get; set; }

        /// <summary>
        /// Column names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<string>? Columns { get; set; }

        /// <summary>
        /// When the dataset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the dataset was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier for the dataset.
        /// </param>
        /// <param name="name">
        /// Name of the dataset.
        /// </param>
        /// <param name="description">
        /// Description of the dataset.
        /// </param>
        /// <param name="status">
        /// Processing status of the dataset.
        /// </param>
        /// <param name="rowCount">
        /// Number of rows in the dataset.
        /// </param>
        /// <param name="columnCount">
        /// Number of columns in the dataset.
        /// </param>
        /// <param name="columns">
        /// Column names.
        /// </param>
        /// <param name="createdAt">
        /// When the dataset was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the dataset was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            string? uuid,
            string? name,
            string? description,
            global::Predibase.DatasetStatus? status,
            int? rowCount,
            int? columnCount,
            global::System.Collections.Generic.IList<string>? columns,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.RowCount = rowCount;
            this.ColumnCount = columnCount;
            this.Columns = columns;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}