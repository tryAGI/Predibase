
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Configuration for a fine-tuning job.
    /// </summary>
    public sealed partial class FinetuningConfig
    {
        /// <summary>
        /// The base model to fine-tune (e.g., meta-llama/Llama-3.3-70B-Instruct).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Adapter type (lora, turbo_lora, turbo).<br/>
        /// Default Value: lora
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter")]
        public string? Adapter { get; set; }

        /// <summary>
        /// Number of training epochs.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epochs")]
        public int? Epochs { get; set; }

        /// <summary>
        /// Number of training steps (overrides epochs if set).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_steps")]
        public int? TrainSteps { get; set; }

        /// <summary>
        /// Learning rate for training.<br/>
        /// Default Value: 0.0002
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// Rank of the LoRA adapter.<br/>
        /// Default Value: 16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Alpha parameter for LoRA scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_alpha")]
        public int? LoraAlpha { get; set; }

        /// <summary>
        /// Dropout rate for LoRA layers.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_dropout")]
        public float? LoraDropout { get; set; }

        /// <summary>
        /// Model modules to apply LoRA to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_modules")]
        public global::System.Collections.Generic.IList<string>? TargetModules { get; set; }

        /// <summary>
        /// Whether to enable early stopping.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_early_stopping")]
        public bool? EnableEarlyStopping { get; set; }

        /// <summary>
        /// Ratio of training steps for learning rate warmup.<br/>
        /// Default Value: 0.03
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_ratio")]
        public float? WarmupRatio { get; set; }

        /// <summary>
        /// Effective batch size for training.<br/>
        /// Default Value: 16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_batch_size")]
        public int? EffectiveBatchSize { get; set; }

        /// <summary>
        /// Fine-tuning task type (e.g., instruction_tuning, classification, continued_pretraining).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// Whether to apply the chat template to the dataset.<br/>
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
        /// Initializes a new instance of the <see cref="FinetuningConfig" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// The base model to fine-tune (e.g., meta-llama/Llama-3.3-70B-Instruct).
        /// </param>
        /// <param name="adapter">
        /// Adapter type (lora, turbo_lora, turbo).<br/>
        /// Default Value: lora
        /// </param>
        /// <param name="epochs">
        /// Number of training epochs.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="trainSteps">
        /// Number of training steps (overrides epochs if set).
        /// </param>
        /// <param name="learningRate">
        /// Learning rate for training.<br/>
        /// Default Value: 0.0002
        /// </param>
        /// <param name="rank">
        /// Rank of the LoRA adapter.<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="loraAlpha">
        /// Alpha parameter for LoRA scaling.
        /// </param>
        /// <param name="loraDropout">
        /// Dropout rate for LoRA layers.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="targetModules">
        /// Model modules to apply LoRA to.
        /// </param>
        /// <param name="enableEarlyStopping">
        /// Whether to enable early stopping.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="warmupRatio">
        /// Ratio of training steps for learning rate warmup.<br/>
        /// Default Value: 0.03
        /// </param>
        /// <param name="effectiveBatchSize">
        /// Effective batch size for training.<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="task">
        /// Fine-tuning task type (e.g., instruction_tuning, classification, continued_pretraining).
        /// </param>
        /// <param name="applyChatTemplate">
        /// Whether to apply the chat template to the dataset.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuningConfig(
            string baseModel,
            string? adapter,
            int? epochs,
            int? trainSteps,
            float? learningRate,
            int? rank,
            int? loraAlpha,
            float? loraDropout,
            global::System.Collections.Generic.IList<string>? targetModules,
            bool? enableEarlyStopping,
            float? warmupRatio,
            int? effectiveBatchSize,
            string? task,
            bool? applyChatTemplate)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.Adapter = adapter;
            this.Epochs = epochs;
            this.TrainSteps = trainSteps;
            this.LearningRate = learningRate;
            this.Rank = rank;
            this.LoraAlpha = loraAlpha;
            this.LoraDropout = loraDropout;
            this.TargetModules = targetModules;
            this.EnableEarlyStopping = enableEarlyStopping;
            this.WarmupRatio = warmupRatio;
            this.EffectiveBatchSize = effectiveBatchSize;
            this.Task = task;
            this.ApplyChatTemplate = applyChatTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuningConfig" /> class.
        /// </summary>
        public FinetuningConfig()
        {
        }
    }
}