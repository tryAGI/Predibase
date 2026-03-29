#nullable enable

namespace Predibase
{
    public partial interface IAdaptersClient
    {
        /// <summary>
        /// Delete Adapter<br/>
        /// Delete a specific adapter version.
        /// </summary>
        /// <param name="repoName"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAdapterAsync(
            string repoName,
            int version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}