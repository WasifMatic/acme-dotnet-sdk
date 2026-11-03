using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi3100.Core.Models;

namespace SwaggerPetstoreOpenApi3100.Models;

public record StoreStatus
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("open")]
    public bool? Open { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("openingHour")]
    public int? OpeningHour { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("closingHour")]
    public int? ClosingHour { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
