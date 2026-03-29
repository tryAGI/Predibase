
#nullable enable

namespace Predibase
{
    /// <summary>
    /// An adapter repository for organizing fine-tuned adapters.
    /// </summary>
    public sealed partial class Repository
    {
        /// <summary>
        /// Unique identifier for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Name of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When the repository was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the repository was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Number of adapters in this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_count")]
        public int? AdapterCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier for the repository.
        /// </param>
        /// <param name="name">
        /// Name of the repository.
        /// </param>
        /// <param name="description">
        /// Description of the repository.
        /// </param>
        /// <param name="createdAt">
        /// When the repository was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the repository was last updated.
        /// </param>
        /// <param name="adapterCount">
        /// Number of adapters in this repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Repository(
            string? uuid,
            string? name,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? adapterCount)
        {
            this.Uuid = uuid;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AdapterCount = adapterCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        public Repository()
        {
        }
    }
}