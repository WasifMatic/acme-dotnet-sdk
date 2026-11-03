using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi3100.Core.Models;

namespace SwaggerPetstoreOpenApi3100.Models;

public record Category
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public long? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    // CUSTOM CODE (QA #465 happy path 2, csharp): hand-written member, must survive regeneration
    [JsonIgnore]
    public string DisplayName => $"{Id}: {Name}";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
