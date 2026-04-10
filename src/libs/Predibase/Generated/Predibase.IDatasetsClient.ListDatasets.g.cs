#nullable enable

namespace Predibase
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Datasets<br/>
        /// List all uploaded datasets.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.DatasetList> ListDatasetsAsync(
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}