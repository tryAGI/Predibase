#nullable enable

namespace Predibase
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Datasets<br/>
        /// List all uploaded datasets.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.DatasetList> ListDatasetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}