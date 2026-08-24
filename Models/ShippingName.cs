using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PayPalServer.Core.Models;

namespace PayPalServer.Models;

/// <summary>
/// The name of the party.
/// </summary>
public record ShippingName
{
    /// <summary>
    /// When the party is a person, the party's full name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("full_name")]
    [MaxLength(300)]
    public string? FullName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
