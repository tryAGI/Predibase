#nullable enable

namespace Predibase
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Update Deployment<br/>
        /// Update an existing deployment's configuration. Note that updating a single-replica deployment may cause brief downtime.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Deployment> UpdateDeploymentAsync(
            string deploymentName,

            global::Predibase.UpdateDeploymentRequest request,
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Deployment<br/>
        /// Update an existing deployment's configuration. Note that updating a single-replica deployment may cause brief downtime.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="description">
        /// Updated description.
        /// </param>
        /// <param name="config">
        /// Configuration for a deployment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.Deployment> UpdateDeploymentAsync(
            string deploymentName,
            string? description = default,
            global::Predibase.DeploymentConfig? config = default,
            global::Predibase.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}