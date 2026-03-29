
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Current status of the deployment.
    /// </summary>
    public enum DeploymentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentStatus value)
        {
            return value switch
            {
                DeploymentStatus.Error => "error",
                DeploymentStatus.Pending => "pending",
                DeploymentStatus.Running => "running",
                DeploymentStatus.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeploymentStatus.Error,
                "pending" => DeploymentStatus.Pending,
                "running" => DeploymentStatus.Running,
                "stopped" => DeploymentStatus.Stopped,
                _ => null,
            };
        }
    }
}