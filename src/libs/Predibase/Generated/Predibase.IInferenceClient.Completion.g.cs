#nullable enable

namespace Predibase
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Completion<br/>
        /// OpenAI-compatible text completion endpoint for a specific deployment.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.CompletionResponse> CompletionAsync(
            string deploymentName,

            global::Predibase.CompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Completion<br/>
        /// OpenAI-compatible text completion endpoint for a specific deployment.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="model">
        /// Adapter model identifier.
        /// </param>
        /// <param name="prompt">
        /// The prompt to complete.
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="maxTokens">
        /// Default Value: 20
        /// </param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="adapterSource"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.CompletionResponse> CompletionAsync(
            string deploymentName,
            string prompt,
            string? model = default,
            float? temperature = default,
            float? topP = default,
            int? n = default,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            bool? stream = default,
            string? adapterSource = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}