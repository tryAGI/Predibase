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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Adapter> GetAdapterAsync(
            string repoName,
            int version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}