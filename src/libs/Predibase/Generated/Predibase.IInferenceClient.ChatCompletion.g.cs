#nullable enable

namespace Predibase
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Chat Completion<br/>
        /// OpenAI-compatible chat completion endpoint for a specific deployment.<br/>
        /// Supports both base model and fine-tuned adapter inference.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.ChatCompletionResponse> ChatCompletionAsync(
            string deploymentName,

            global::Predibase.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completion<br/>
        /// OpenAI-compatible chat completion endpoint for a specific deployment.<br/>
        /// Supports both base model and fine-tuned adapter inference.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="model">
        /// Adapter model identifier (e.g., repo_name/version).
        /// </param>
        /// <param name="messages">
        /// Chat messages.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0 to 2).
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling probability (0 to 1).
        /// </param>
        /// <param name="n">
        /// Number of completions to generate.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="stop">
        /// Up to 4 stop sequences.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="adapterSource">
        /// Source of the adapter (pbase, hub, s3).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.ChatCompletionResponse> ChatCompletionAsync(
            string deploymentName,
            global::System.Collections.Generic.IList<global::Predibase.ChatMessage> messages,
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