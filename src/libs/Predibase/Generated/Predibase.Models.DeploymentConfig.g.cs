
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Configuration for a deployment.
    /// </summary>
    public sealed partial class DeploymentConfig
    {
        /// <summary>
        /// The base model to deploy (e.g., meta-llama/Llama-3.3-70B-Instruct).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// GPU accelerator type to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerator")]
        public string? Accelerator { get; set; }

        /// <summary>
        /// Minimum number of replicas (default 0 for scale-to-zero).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replicas")]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// Maximum number of replicas.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replicas")]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// Seconds of inactivity before scaling down replicas (default 3600).<br/>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cooldown_time")]
        public int? CooldownTime { get; set; }

        /// <summary>
        /// Number of simultaneous requests before scaling up (default 1).<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_up_threshold")]
        public int? ScaleUpThreshold { get; set; }

        /// <summary>
        /// Quantization method for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Predibase.JsonConverters.DeploymentConfigQuantizationJsonConverter))]
        public global::Predibase.DeploymentConfigQuantization? Quantization { get; set; }

        /// <summary>
        /// Maximum number of tokens per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_tokens")]
        public int? MaxTotalTokens { get; set; }

        /// <summary>
        /// Whether to enable request logging.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_logging_enabled")]
        public bool? RequestLoggingEnabled { get; set; }

        /// <summary>
        /// List of adapter IDs to preload on deployment initialization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preloaded_adapters")]
        public global::System.Collections.Generic.IList<string>? PreloadedAdapters { get; set; }

        /// <summary>
        /// Whether to enable prefix caching.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_caching")]
        public bool? PrefixCaching { get; set; }

        /// <summary>
        /// Speculator to use for speculative decoding (auto, disabled, or adapter ID).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speculator")]
        public string? Speculator { get; set; }

        /// <summary>
        /// Hugging Face token for private models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hf_token")]
        public string? HfToken { get; set; }

        /// <summary>
        /// Creates a direct endpoint bypassing the Predibase control plane.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direct_ingress")]
        public bool? DirectIngress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentConfig" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// The base model to deploy (e.g., meta-llama/Llama-3.3-70B-Instruct).
        /// </param>
        /// <param name="accelerator">
        /// GPU accelerator type to use.
        /// </param>
        /// <param name="minReplicas">
        /// Minimum number of replicas (default 0 for scale-to-zero).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxReplicas">
        /// Maximum number of replicas.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cooldownTime">
        /// Seconds of inactivity before scaling down replicas (default 3600).<br/>
        /// Default Value: 3600
        /// </param>
        /// <param name="scaleUpThreshold">
        /// Number of simultaneous requests before scaling up (default 1).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="quantization">
        /// Quantization method for the model.
        /// </param>
        /// <param name="maxTotalTokens">
        /// Maximum number of tokens per request.
        /// </param>
        /// <param name="requestLoggingEnabled">
        /// Whether to enable request logging.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="preloadedAdapters">
        /// List of adapter IDs to preload on deployment initialization.
        /// </param>
        /// <param name="prefixCaching">
        /// Whether to enable prefix caching.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speculator">
        /// Speculator to use for speculative decoding (auto, disabled, or adapter ID).
        /// </param>
        /// <param name="hfToken">
        /// Hugging Face token for private models.
        /// </param>
        /// <param name="directIngress">
        /// Creates a direct endpoint bypassing the Predibase control plane.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentConfig(
            string baseModel,
            string? accelerator,
            int? minReplicas,
            int? maxReplicas,
            int? cooldownTime,
            int? scaleUpThreshold,
            global::Predibase.DeploymentConfigQuantization? quantization,
            int? maxTotalTokens,
            bool? requestLoggingEnabled,
            global::System.Collections.Generic.IList<string>? preloadedAdapters,
            bool? prefixCaching,
            string? speculator,
            string? hfToken,
            bool? directIngress)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.Accelerator = accelerator;
            this.MinReplicas = minReplicas;
            this.MaxReplicas = maxReplicas;
            this.CooldownTime = cooldownTime;
            this.ScaleUpThreshold = scaleUpThreshold;
            this.Quantization = quantization;
            this.MaxTotalTokens = maxTotalTokens;
            this.RequestLoggingEnabled = requestLoggingEnabled;
            this.PreloadedAdapters = preloadedAdapters;
            this.PrefixCaching = prefixCaching;
            this.Speculator = speculator;
            this.HfToken = hfToken;
            this.DirectIngress = directIngress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentConfig" /> class.
        /// </summary>
        public DeploymentConfig()
        {
        }
    }
}