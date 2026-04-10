#nullable enable

namespace Predibase
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Generate<br/>
        /// LoRAX native generate endpoint for a specific deployment.<br/>
        /// Generates tokens and waits for completion. Supports adapter switching.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.GenerateResponse> GenerateAsync(
            string deploymentName,

            global::Predibase.GenerateRequest request,
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate<br/>
        /// LoRAX native generate endpoint for a specific deployment.<br/>
        /// Generates tokens and waits for completion. Supports adapter switching.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="inputs">
        /// The prompt text.
        /// </param>
        /// <param name="parameters">
        /// Parameters for text generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.GenerateResponse> GenerateAsync(
            string deploymentName,
            string inputs,
            global::Predibase.GenerateParameters? parameters = default,
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}