#nullable enable

namespace Predibase
{
    public partial interface IRepositoriesClient
    {
        /// <summary>
        /// List Repositories<br/>
        /// List adapter repositories with optional limit.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.RepositoryList> ListRepositoriesAsync(
            int? limit = default,
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}