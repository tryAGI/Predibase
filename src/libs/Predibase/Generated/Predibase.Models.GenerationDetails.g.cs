
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Details about the generation process.
    /// </summary>
    public sealed partial class GenerationDetails
    {
        /// <summary>
        /// Reason for generation completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Predibase.JsonConverters.GenerationDetailsFinishReasonJsonConverter))]
        public global::Predibase.GenerationDetailsFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Number of generated tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_tokens")]
        public int? GeneratedTokens { get; set; }

        /// <summary>
        /// Random seed used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationDetails" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// Reason for generation completion.
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt.
        /// </param>
        /// <param name="generatedTokens">
        /// Number of generated tokens.
        /// </param>
        /// <param name="seed">
        /// Random seed used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationDetails(
            global::Predibase.GenerationDetailsFinishReason? finishReason,
            int? promptTokens,
            int? generatedTokens,
            long? seed)
        {
            this.FinishReason = finishReason;
            this.PromptTokens = promptTokens;
            this.GeneratedTokens = generatedTokens;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationDetails" /> class.
        /// </summary>
        public GenerationDetails()
        {
        }
    }
}