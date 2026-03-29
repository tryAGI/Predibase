
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Predibase
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Predibase.JsonConverters.DeploymentStatusJsonConverter),

            typeof(global::Predibase.JsonConverters.DeploymentStatusNullableJsonConverter),

            typeof(global::Predibase.JsonConverters.DeploymentConfigQuantizationJsonConverter),

            typeof(global::Predibase.JsonConverters.DeploymentConfigQuantizationNullableJsonConverter),

            typeof(global::Predibase.JsonConverters.AdapterStatusJsonConverter),

            typeof(global::Predibase.JsonConverters.AdapterStatusNullableJsonConverter),

            typeof(global::Predibase.JsonConverters.FinetuningJobStatusJsonConverter),

            typeof(global::Predibase.JsonConverters.FinetuningJobStatusNullableJsonConverter),

            typeof(global::Predibase.JsonConverters.DatasetStatusJsonConverter),

            typeof(global::Predibase.JsonConverters.DatasetStatusNullableJsonConverter),

            typeof(global::Predibase.JsonConverters.GenerationDetailsFinishReasonJsonConverter),

            typeof(global::Predibase.JsonConverters.GenerationDetailsFinishReasonNullableJsonConverter),

            typeof(global::Predibase.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.Deployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.DeploymentStatus), TypeInfoPropertyName = "DeploymentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.DeploymentConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.DeploymentConfigQuantization), TypeInfoPropertyName = "DeploymentConfigQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.CreateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.UpdateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.DeploymentList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.Deployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.Repository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.CreateRepositoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.RepositoryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.Repository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.Adapter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.AdapterStatus), TypeInfoPropertyName = "AdapterStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.AdapterList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.Adapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.FinetuningConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.CreateFinetuningJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.FinetuningJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.FinetuningJobStatus), TypeInfoPropertyName = "FinetuningJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.FinetuningJobList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.FinetuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.DatasetStatus), TypeInfoPropertyName = "DatasetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.DatasetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.CompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.CompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.CompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.GenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.GenerateParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.GenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.GenerationDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.GenerationDetailsFinishReason), TypeInfoPropertyName = "GenerationDetailsFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ClassifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ClassifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Predibase.ClassificationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ClassificationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.DeploymentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.HealthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Predibase.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.Deployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.Repository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.Adapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.FinetuningJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.CompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Predibase.ClassificationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}