#nullable enable

namespace Predibase
{
    public partial interface IRepositoriesClient
    {
        /// <summary>
        /// Create Repository<br/>
        /// Create a new adapter repository for organizing fine-tuned adapters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Repository> CreateRepositoryAsync(

            global::Predibase.CreateRepositoryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Repository<br/>
        /// Create a new adapter repository for organizing fine-tuned adapters.
        /// </summary>
        /// <param name="name">
        /// Name for the repository.
        /// </param>
        /// <param name="description">
        /// Description for the repository.
        /// </param>
        /// <param name="existsOk">
        /// If true, returns existing repo instead of raising an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Repository> CreateRepositoryAsync(
            string name,
            string? description = default,
            bool? existsOk = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}