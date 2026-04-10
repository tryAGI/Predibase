#nullable enable

namespace Predibase
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset<br/>
        /// Get details of a specific dataset.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Dataset> GetDatasetAsync(
            string datasetName,
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}