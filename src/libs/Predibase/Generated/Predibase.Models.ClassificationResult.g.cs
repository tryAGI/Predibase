
#nullable enable

namespace Predibase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassificationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Predicted class label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Class probabilities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probs")]
        public global::System.Collections.Generic.IList<float>? Probs { get; set; }

        /// <summary>
        /// Total number of classes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_classes")]
        public int? NumClasses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResult" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="label">
        /// Predicted class label.
        /// </param>
        /// <param name="probs">
        /// Class probabilities.
        /// </param>
        /// <param name="numClasses">
        /// Total number of classes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationResult(
            int? index,
            string? label,
            global::System.Collections.Generic.IList<float>? probs,
            int? numClasses)
        {
            this.Index = index;
            this.Label = label;
            this.Probs = probs;
            this.NumClasses = numClasses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResult" /> class.
        /// </summary>
        public ClassificationResult()
        {
        }
    }
}