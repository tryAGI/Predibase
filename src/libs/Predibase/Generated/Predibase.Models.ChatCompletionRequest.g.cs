
#nullable enable

namespace Predibase
{
    /// <summary>
    /// OpenAI-compatible chat completion request.
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// Adapter model identifier (e.g., repo_name/version).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Chat messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Predibase.ChatMessage> Messages { get; set; }

        /// <summary>
        /// Sampling temperature (0 to 2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling probability (0 to 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Number of completions to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Up to 4 stop sequences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Source of the adapter (pbase, hub, s3).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_source")]
        public string? AdapterSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Chat messages.
        /// </param>
        /// <param name="model">
        /// Adapter model identifier (e.g., repo_name/version).
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0 to 2).
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability (0 to 1).
        /// </param>
        /// <param name="n">
        /// Number of completions to generate.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="stop">
        /// Up to 4 stop sequences.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="adapterSource">
        /// Source of the adapter (pbase, hub, s3).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            global::System.Collections.Generic.IList<global::Predibase.ChatMessage> messages,
            string? model,
            float? temperature,
            float? topP,
            int? n,
            int? maxTokens,
            global::System.Collections.Generic.IList<string>? stop,
            bool? stream,
            string? adapterSource)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.MaxTokens = maxTokens;
            this.Stop = stop;
            this.Stream = stream;
            this.AdapterSource = adapterSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}