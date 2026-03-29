
#nullable enable

namespace Predibase
{
    /// <summary>
    /// A fine-tuned LoRA adapter.
    /// </summary>
    public sealed partial class Adapter
    {
        /// <summary>
        /// Unique identifier for the adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Repository the adapter belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// Version number of the adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Description of the adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Base model this adapter was fine-tuned from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Current status of the adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Predibase.JsonConverters.AdapterStatusJsonConverter))]
        public global::Predibase.AdapterStatus? Status { get; set; }

        /// <summary>
        /// When the adapter was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the adapter was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Adapter" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier for the adapter.
        /// </param>
        /// <param name="repo">
        /// Repository the adapter belongs to.
        /// </param>
        /// <param name="version">
        /// Version number of the adapter.
        /// </param>
        /// <param name="description">
        /// Description of the adapter.
        /// </param>
        /// <param name="baseModel">
        /// Base model this adapter was fine-tuned from.
        /// </param>
        /// <param name="status">
        /// Current status of the adapter.
        /// </param>
        /// <param name="createdAt">
        /// When the adapter was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the adapter was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Adapter(
            string? uuid,
            string? repo,
            int? version,
            string? description,
            string? baseModel,
            global::Predibase.AdapterStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.Repo = repo;
            this.Version = version;
            this.Description = description;
            this.BaseModel = baseModel;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Adapter" /> class.
        /// </summary>
        public Adapter()
        {
        }
    }
}