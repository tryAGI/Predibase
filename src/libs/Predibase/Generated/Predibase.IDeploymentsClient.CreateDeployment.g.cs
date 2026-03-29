#nullable enable

namespace Predibase
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Create Deployment<br/>
        /// Create a new private serverless deployment with the specified base model and configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Deployment> CreateDeploymentAsync(

            global::Predibase.CreateDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Deployment<br/>
        /// Create a new private serverless deployment with the specified base model and configuration.
        /// </summary>
        /// <param name="name">
        /// Name for the deployment.
        /// </param>
        /// <param name="description">
        /// Description for the deployment.
        /// </param>
        /// <param name="config">
        /// Configuration for a deployment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Deployment> CreateDeploymentAsync(
            string name,
            global::Predibase.DeploymentConfig config,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}