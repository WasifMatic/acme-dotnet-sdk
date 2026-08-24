using System.Text.Json.Serialization;
using PayPalServer.Core.Models;
using PayPalServer.Core.Validation;
using PayPalServer.Core.Validation.Attributes;

namespace PayPalServer.Models;

/// <summary>
/// Customizes the payer experience during the 3DS Approval for payment.
/// </summary>
public record CardExperienceContext
{
    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_url")]
    [Format(FormatKind.Uri)]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_url")]
    [Format(FormatKind.Uri)]
    public string? CancelUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
