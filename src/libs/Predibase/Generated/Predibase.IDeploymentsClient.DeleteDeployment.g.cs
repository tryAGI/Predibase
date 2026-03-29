#nullable enable

namespace Predibase
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Delete Deployment<br/>
        /// Delete a deployment by name.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDeploymentAsync(
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}