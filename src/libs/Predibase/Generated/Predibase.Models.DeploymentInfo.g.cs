
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Information about the inference endpoint.
    /// </summary>
    public sealed partial class DeploymentInfo
    {
        /// <summary>
        /// The model deployed on this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Model data type (e.g., torch.float16).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_dtype")]
        public string? ModelDtype { get; set; }

        /// <summary>
        /// Device type (e.g., cuda).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_device_type")]
        public string? ModelDeviceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_requests")]
        public int? MaxConcurrentRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_input_length")]
        public int? MaxInputLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_tokens")]
        public int? MaxTotalTokens { get; set; }

        /// <summary>
        /// LoRAX server version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentInfo" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model deployed on this endpoint.
        /// </param>
        /// <param name="modelDtype">
        /// Model data type (e.g., torch.float16).
        /// </param>
        /// <param name="modelDeviceType">
        /// Device type (e.g., cuda).
        /// </param>
        /// <param name="maxConcurrentRequests"></param>
        /// <param name="maxInputLength"></param>
        /// <param name="maxTotalTokens"></param>
        /// <param name="version">
        /// LoRAX server version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentInfo(
            string? modelId,
            string? modelDtype,
            string? modelDeviceType,
            int? maxConcurrentRequests,
            int? maxInputLength,
            int? maxTotalTokens,
            string? version)
        {
            this.ModelId = modelId;
            this.ModelDtype = modelDtype;
            this.ModelDeviceType = modelDeviceType;
            this.MaxConcurrentRequests = maxConcurrentRequests;
            this.MaxInputLength = maxInputLength;
            this.MaxTotalTokens = maxTotalTokens;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentInfo" /> class.
        /// </summary>
        public DeploymentInfo()
        {
        }
    }
}