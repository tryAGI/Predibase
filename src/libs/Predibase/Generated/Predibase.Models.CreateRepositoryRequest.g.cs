
#nullable enable

namespace Predibase
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRepositoryRequest
    {
        /// <summary>
        /// Name for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// If true, returns existing repo instead of raising an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exists_ok")]
        public bool? ExistsOk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepositoryRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the repository.
        /// </param>
        /// <param name="description">
        /// Description for the repository.
        /// </param>
        /// <param name="existsOk">
        /// If true, returns existing repo instead of raising an error.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRepositoryRequest(
            string name,
            string? description,
            bool? existsOk)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ExistsOk = existsOk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepositoryRequest" /> class.
        /// </summary>
        public CreateRepositoryRequest()
        {
        }
    }
}