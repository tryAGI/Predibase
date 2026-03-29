#nullable enable

namespace Predibase
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Get Deployment<br/>
        /// Get details of a specific deployment by name.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Deployment> GetDeploymentAsync(
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}