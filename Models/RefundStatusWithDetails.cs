using System.Text.Json.Serialization;
using PayPalServer.Core.Models;
using PayPalServer.Models.Enums;

namespace PayPalServer.Models;

/// <summary>
/// The refund status with details.
/// </summary>
public record RefundStatusWithDetails
{
    /// <summary>
    /// The status of the refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public RefundStatus? Status { get; init; }

    /// <summary>
    /// The details of the refund status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status_details")]
    public RefundStatusDetails? StatusDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
