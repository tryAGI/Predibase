#nullable enable

namespace Predibase
{
    public partial interface IAdaptersClient
    {
        /// <summary>
        /// Get Adapter<br/>
        /// Get details of a specific adapter version.
        /// </summary>
        /// <param name="repoName"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Adapter> GetAdapterAsync(
            string repoName,
            int version,
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}