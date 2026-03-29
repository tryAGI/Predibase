#nullable enable

namespace Predibase
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Cancel Fine-tuning Job<br/>
        /// Cancel an in-progress fine-tuning job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelFinetuningJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}