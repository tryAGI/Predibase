
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Parameters for text generation.
    /// </summary>
    public sealed partial class GenerateParameters
    {
        /// <summary>
        /// Maximum number of new tokens to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_new_tokens")]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// Sampling temperature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Top-K sampling parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Nucleus sampling probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Whether to use sampling instead of greedy decoding.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_sample")]
        public bool? DoSample { get; set; }

        /// <summary>
        /// Penalty for repeating tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public float? RepetitionPenalty { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Up to 4 stop sequences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Whether to include generation details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public bool? Details { get; set; }

        /// <summary>
        /// Whether to return the full text including the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_full_text")]
        public bool? ReturnFullText { get; set; }

        /// <summary>
        /// Adapter ID for fine-tuned model inference (format repo_name/version).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_id")]
        public string? AdapterId { get; set; }

        /// <summary>
        /// Source of the adapter (pbase, hub, s3).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_source")]
        public string? AdapterSource { get; set; }

        /// <summary>
        /// JSON schema for structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// Whether to apply the chat template to the input.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_chat_template")]
        public bool? ApplyChatTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateParameters" /> class.
        /// </summary>
        /// <param name="maxNewTokens">
        /// Maximum number of new tokens to generate.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature.
        /// </param>
        /// <param name="topK">
        /// Top-K sampling parameter.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability.
        /// </param>
        /// <param name="doSample">
        /// Whether to use sampling instead of greedy decoding.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalty for repeating tokens.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="stop">
        /// Up to 4 stop sequences.
        /// </param>
        /// <param name="details">
        /// Whether to include generation details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnFullText">
        /// Whether to return the full text including the prompt.
        /// </param>
        /// <param name="adapterId">
        /// Adapter ID for fine-tuned model inference (format repo_name/version).
        /// </param>
        /// <param name="adapterSource">
        /// Source of the adapter (pbase, hub, s3).
        /// </param>
        /// <param name="schema">
        /// JSON schema for structured output.
        /// </param>
        /// <param name="applyChatTemplate">
        /// Whether to apply the chat template to the input.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateParameters(
            int? maxNewTokens,
            float? temperature,
            int? topK,
            float? topP,
            bool? doSample,
            float? repetitionPenalty,
            long? seed,
            global::System.Collections.Generic.IList<string>? stop,
            bool? details,
            bool? returnFullText,
            string? adapterId,
            string? adapterSource,
            string? schema,
            bool? applyChatTemplate)
        {
            this.MaxNewTokens = maxNewTokens;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopP = topP;
            this.DoSample = doSample;
            this.RepetitionPenalty = repetitionPenalty;
            this.Seed = seed;
            this.Stop = stop;
            this.Details = details;
            this.ReturnFullText = returnFullText;
            this.AdapterId = adapterId;
            this.AdapterSource = adapterSource;
            this.Schema = schema;
            this.ApplyChatTemplate = applyChatTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateParameters" /> class.
        /// </summary>
        public GenerateParameters()
        {
        }
    }
}