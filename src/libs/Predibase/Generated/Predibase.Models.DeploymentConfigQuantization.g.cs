
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Quantization method for the model.
    /// </summary>
    public enum DeploymentConfigQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        BitsandbytesNf4,
        /// <summary>
        /// 
        /// </summary>
        Fp8,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentConfigQuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentConfigQuantization value)
        {
            return value switch
            {
                DeploymentConfigQuantization.BitsandbytesNf4 => "bitsandbytes-nf4",
                DeploymentConfigQuantization.Fp8 => "fp8",
                DeploymentConfigQuantization.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentConfigQuantization? ToEnum(string value)
        {
            return value switch
            {
                "bitsandbytes-nf4" => DeploymentConfigQuantization.BitsandbytesNf4,
                "fp8" => DeploymentConfigQuantization.Fp8,
                "none" => DeploymentConfigQuantization.None,
                _ => null,
            };
        }
    }
}