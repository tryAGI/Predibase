
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Batch classification response.
    /// </summary>
    public sealed partial class ClassifyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public long? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Predibase.ClassificationResult>? Data { get; set; }

        /// <summary>
        /// Token usage information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Predibase.UsageInfo? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="data"></param>
        /// <param name="usage">
        /// Token usage information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyResponse(
            string? id,
            string? @object,
            long? created,
            string? model,
            global::System.Collections.Generic.IList<global::Predibase.ClassificationResult>? data,
            global::Predibase.UsageInfo? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Data = data;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponse" /> class.
        /// </summary>
        public ClassifyResponse()
        {
        }
    }
}