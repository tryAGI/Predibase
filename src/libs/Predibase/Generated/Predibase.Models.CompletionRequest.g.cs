
#nullable enable

namespace Predibase
{
    /// <summary>
    /// OpenAI-compatible completion request.
    /// </summary>
    public sealed partial class CompletionRequest
    {
        /// <summary>
        /// Adapter model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The prompt to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter_source")]
        public string? AdapterSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to complete.
        /// </param>
        /// <param name="model">
        /// Adapter model identifier.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="maxTokens">
        /// Default Value: 20
        /// </param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="adapterSource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionRequest(
            string prompt,
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
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.MaxTokens = maxTokens;
            this.Stop = stop;
            this.Stream = stream;
            this.AdapterSource = adapterSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionRequest" /> class.
        /// </summary>
        public CompletionRequest()
        {
        }
    }
}