#nullable enable

namespace Predibase
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Classify<br/>
        /// Batch classification endpoint for one or more inputs using a classification adapter.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.ClassifyResponse> ClassifyAsync(
            string deploymentName,

            global::Predibase.ClassifyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Classify<br/>
        /// Batch classification endpoint for one or more inputs using a classification adapter.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="input">
        /// List of texts to classify.
        /// </param>
        /// <param name="model">
        /// Classification adapter model identifier.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.ClassifyResponse> ClassifyAsync(
            string deploymentName,
            global::System.Collections.Generic.IList<string> input,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}