#nullable enable

namespace Predibase
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete Dataset<br/>
        /// Delete a dataset.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetAsync(
            string datasetName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}