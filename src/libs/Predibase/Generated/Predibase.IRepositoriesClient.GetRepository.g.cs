#nullable enable

namespace Predibase
{
    public partial interface IRepositoriesClient
    {
        /// <summary>
        /// Get Repository<br/>
        /// Get details of a specific repository by name.
        /// </summary>
        /// <param name="repoName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Repository> GetRepositoryAsync(
            string repoName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}