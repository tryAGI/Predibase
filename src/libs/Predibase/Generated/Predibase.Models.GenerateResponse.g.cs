
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Response from the generate endpoint.
    /// </summary>
    public sealed partial class GenerateResponse
    {
        /// <summary>
        /// The generated text completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedText { get; set; }

        /// <summary>
        /// Details about the generation process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Predibase.GenerationDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateResponse" /> class.
        /// </summary>
        /// <param name="generatedText">
        /// The generated text completion.
        /// </param>
        /// <param name="details">
        /// Details about the generation process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateResponse(
            string generatedText,
            global::Predibase.GenerationDetails? details)
        {
            this.GeneratedText = generatedText ?? throw new global::System.ArgumentNullException(nameof(generatedText));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateResponse" /> class.
        /// </summary>
        public GenerateResponse()
        {
        }
    }
}