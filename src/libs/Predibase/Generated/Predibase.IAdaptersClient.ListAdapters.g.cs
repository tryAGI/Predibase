#nullable enable

namespace Predibase
{
    public partial interface IAdaptersClient
    {
        /// <summary>
        /// List Adapters<br/>
        /// List all adapters in a repository.
        /// </summary>
        /// <param name="repoName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.AdapterList> ListAdaptersAsync(
            string repoName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}