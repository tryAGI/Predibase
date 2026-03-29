
#nullable enable

namespace Predibase
{
    /// <summary>
    /// Reason for generation completion.
    /// </summary>
    public enum GenerationDetailsFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        EosToken,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationDetailsFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationDetailsFinishReason value)
        {
            return value switch
            {
                GenerationDetailsFinishReason.EosToken => "eos_token",
                GenerationDetailsFinishReason.Length => "length",
                GenerationDetailsFinishReason.StopSequence => "stop_sequence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationDetailsFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "eos_token" => GenerationDetailsFinishReason.EosToken,
                "length" => GenerationDetailsFinishReason.Length,
                "stop_sequence" => GenerationDetailsFinishReason.StopSequence,
                _ => null,
            };
        }
    }
}