#nullable enable

namespace Predibase
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// List Deployments<br/>
        /// List all private serverless deployments.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.DeploymentList> ListDeploymentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}