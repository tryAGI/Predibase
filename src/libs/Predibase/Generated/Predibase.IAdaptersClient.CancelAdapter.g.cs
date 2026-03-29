#nullable enable

namespace Predibase
{
    public partial interface IAdaptersClient
    {
        /// <summary>
        /// Cancel Adapter Training<br/>
        /// Cancel an in-progress adapter training job.
        /// </summary>
        /// <param name="repoName"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelAdapterAsync(
            string repoName,
            int version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}