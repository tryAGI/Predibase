#nullable enable

namespace Predibase
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// List Fine-tuning Jobs<br/>
        /// List all fine-tuning jobs.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Predibase.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Predibase.FinetuningJobList> ListFinetuningJobsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}