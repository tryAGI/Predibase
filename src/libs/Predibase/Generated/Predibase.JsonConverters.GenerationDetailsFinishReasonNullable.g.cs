#nullable enable

namespace Predibase.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerationDetailsFinishReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Predibase.GenerationDetailsFinishReason?>
    {
        /// <inheritdoc />
        public override global::Predibase.GenerationDetailsFinishReason? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Predibase.GenerationDetailsFinishReasonExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Predibase.GenerationDetailsFinishReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Predibase.GenerationDetailsFinishReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Predibase.GenerationDetailsFinishReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Predibase.GenerationDetailsFinishReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
