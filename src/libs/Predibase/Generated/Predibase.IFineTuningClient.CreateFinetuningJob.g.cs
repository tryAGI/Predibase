#nullable enable

namespace Predibase
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Create Fine-tuning Job<br/>
        /// Create a new LoRA fine-tuning job. This is an asynchronous operation<br/>
        /// that starts training and returns immediately with the job details.<br/>
        /// Use the job ID to poll for status.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.FinetuningJob> CreateFinetuningJobAsync(

            global::Predibase.CreateFinetuningJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Fine-tuning Job<br/>
        /// Create a new LoRA fine-tuning job. This is an asynchronous operation<br/>
        /// that starts training and returns immediately with the job details.<br/>
        /// Use the job ID to poll for status.
        /// </summary>
        /// <param name="config">
        /// Configuration for a fine-tuning job.
        /// </param>
        /// <param name="dataset">
        /// Name of the dataset to use for fine-tuning.
        /// </param>
        /// <param name="repo">
        /// Name of the adapter repository to store the fine-tuned adapter.
        /// </param>
        /// <param name="description">
        /// Description for the fine-tuning job.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.FinetuningJob> CreateFinetuningJobAsync(
            global::Predibase.FinetuningConfig config,
            string dataset,
            string repo,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}