#nullable enable

namespace Predibase
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Deployment Info<br/>
        /// Get information about the inference endpoint including model details and limits.
        /// </summary>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.DeploymentInfo> GetDeploymentInfoAsync(
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}