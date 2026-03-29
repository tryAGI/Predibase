#nullable enable

namespace Predibase
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get Fine-tuning Job<br/>
        /// Get details and status of a specific fine-tuning job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.FinetuningJob> GetFinetuningJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}