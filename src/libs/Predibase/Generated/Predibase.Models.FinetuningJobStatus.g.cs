
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Current status of the job.
    /// </summary>
    public enum FinetuningJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuningJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuningJobStatus value)
        {
            return value switch
            {
                FinetuningJobStatus.Cancelled => "cancelled",
                FinetuningJobStatus.Completed => "completed",
                FinetuningJobStatus.Failed => "failed",
                FinetuningJobStatus.Pending => "pending",
                FinetuningJobStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuningJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => FinetuningJobStatus.Cancelled,
                "completed" => FinetuningJobStatus.Completed,
                "failed" => FinetuningJobStatus.Failed,
                "pending" => FinetuningJobStatus.Pending,
                "running" => FinetuningJobStatus.Running,
                _ => null,
            };
        }
    }
}