#nullable enable

namespace Predibase
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Deployment Health<br/>
        /// Health check for a specific deployment.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.HealthResponse> GetDeploymentHealthAsync(
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}