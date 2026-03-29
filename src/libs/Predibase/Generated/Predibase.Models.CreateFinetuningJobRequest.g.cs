
#nullable enable

namespace Predibase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFinetuningJobRequest
    {
        /// <summary>
        /// Configuration for a fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Predibase.FinetuningConfig Config { get; set; }

        /// <summary>
        /// Name of the dataset to use for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// Name of the adapter repository to store the fine-tuned adapter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// Description for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFinetuningJobRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Configuration for a fine-tuning job.
        /// </param>
        /// <param name="dataset">
        /// Name of the dataset to use for fine-tuning.
        /// </param>
        /// <param name="repo">
        /// Name of the adapter repository to store the fine-tuned adapter.
        /// </param>
        /// <param name="description">
        /// Description for the fine-tuning job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFinetuningJobRequest(
            global::Predibase.FinetuningConfig config,
            string dataset,
            string repo,
            string? description)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFinetuningJobRequest" /> class.
        /// </summary>
        public CreateFinetuningJobRequest()
        {
        }
    }
}