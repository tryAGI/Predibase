
#nullable enable

namespace Predibase
{
    /// <summary>
    /// A fine-tuning job.
    /// </summary>
    public sealed partial class FinetuningJob
    {
        /// <summary>
        /// Unique identifier for the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Current status of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Predibase.JsonConverters.FinetuningJobStatusJsonConverter))]
        public global::Predibase.FinetuningJobStatus? Status { get; set; }

        /// <summary>
        /// Dataset used for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public string? Dataset { get; set; }

        /// <summary>
        /// Adapter repository name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// Configuration for a fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Predibase.FinetuningConfig? Config { get; set; }

        /// <summary>
        /// Description of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Version number of the resulting adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_version")]
        public int? AdapterVersion { get; set; }

        /// <summary>
        /// When the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the job was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuningJob" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier for the job.
        /// </param>
        /// <param name="status">
        /// Current status of the job.
        /// </param>
        /// <param name="dataset">
        /// Dataset used for fine-tuning.
        /// </param>
        /// <param name="repo">
        /// Adapter repository name.
        /// </param>
        /// <param name="config">
        /// Configuration for a fine-tuning job.
        /// </param>
        /// <param name="description">
        /// Description of the job.
        /// </param>
        /// <param name="adapterVersion">
        /// Version number of the resulting adapter.
        /// </param>
        /// <param name="createdAt">
        /// When the job was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the job was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuningJob(
            string? uuid,
            global::Predibase.FinetuningJobStatus? status,
            string? dataset,
            string? repo,
            global::Predibase.FinetuningConfig? config,
            string? description,
            int? adapterVersion,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.Dataset = dataset;
            this.Repo = repo;
            this.Config = config;
            this.Description = description;
            this.AdapterVersion = adapterVersion;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuningJob" /> class.
        /// </summary>
        public FinetuningJob()
        {
        }
    }
}