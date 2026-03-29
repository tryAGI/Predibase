
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Processing status of the dataset.
    /// </summary>
    public enum DatasetStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetStatus value)
        {
            return value switch
            {
                DatasetStatus.Error => "error",
                DatasetStatus.Processing => "processing",
                DatasetStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DatasetStatus.Error,
                "processing" => DatasetStatus.Processing,
                "ready" => DatasetStatus.Ready,
                _ => null,
            };
        }
    }
}