
#nullable enable

namespace Predibase
{
    /// <summary>
    /// A private serverless LLM deployment.
    /// </summary>
    public sealed partial class Deployment
    {
        /// <summary>
        /// Unique identifier for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Name of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Current status of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Predibase.JsonConverters.DeploymentStatusJsonConverter))]
        public global::Predibase.DeploymentStatus? Status { get; set; }

        /// <summary>
        /// Base model used by the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Serving endpoint URL for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// When the deployment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the deployment was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Configuration for a deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Predibase.DeploymentConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier for the deployment.
        /// </param>
        /// <param name="name">
        /// Name of the deployment.
        /// </param>
        /// <param name="description">
        /// Description of the deployment.
        /// </param>
        /// <param name="status">
        /// Current status of the deployment.
        /// </param>
        /// <param name="model">
        /// Base model used by the deployment.
        /// </param>
        /// <param name="endpoint">
        /// Serving endpoint URL for the deployment.
        /// </param>
        /// <param name="createdAt">
        /// When the deployment was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the deployment was last updated.
        /// </param>
        /// <param name="config">
        /// Configuration for a deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Deployment(
            string? uuid,
            string? name,
            string? description,
            global::Predibase.DeploymentStatus? status,
            string? model,
            string? endpoint,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::Predibase.DeploymentConfig? config)
        {
            this.Uuid = uuid;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.Model = model;
            this.Endpoint = endpoint;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        public Deployment()
        {
        }
    }
}