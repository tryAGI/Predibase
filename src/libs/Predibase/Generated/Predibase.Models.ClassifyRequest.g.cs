
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Batch classification request.
    /// </summary>
    public sealed partial class ClassifyRequest
    {
        /// <summary>
        /// List of texts to classify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Input { get; set; }

        /// <summary>
        /// Classification adapter model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// List of texts to classify.
        /// </param>
        /// <param name="model">
        /// Classification adapter model identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyRequest(
            global::System.Collections.Generic.IList<string> input,
            string model)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyRequest" /> class.
        /// </summary>
        public ClassifyRequest()
        {
        }
    }
}