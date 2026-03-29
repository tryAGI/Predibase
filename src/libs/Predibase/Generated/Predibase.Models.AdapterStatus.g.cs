
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Current status of the adapter.
    /// </summary>
    public enum AdapterStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdapterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdapterStatus value)
        {
            return value switch
            {
                AdapterStatus.Archived => "archived",
                AdapterStatus.Cancelled => "cancelled",
                AdapterStatus.Failed => "failed",
                AdapterStatus.Pending => "pending",
                AdapterStatus.Ready => "ready",
                AdapterStatus.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdapterStatus? ToEnum(string value)
        {
            return value switch
            {
                "archived" => AdapterStatus.Archived,
                "cancelled" => AdapterStatus.Cancelled,
                "failed" => AdapterStatus.Failed,
                "pending" => AdapterStatus.Pending,
                "ready" => AdapterStatus.Ready,
                "training" => AdapterStatus.Training,
                _ => null,
            };
        }
    }
}