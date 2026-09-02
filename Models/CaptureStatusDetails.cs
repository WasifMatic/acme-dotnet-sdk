using System.Text.Json.Serialization;
using PayPalServer.Core.Models;
using PayPalServer.Models.Enums;

namespace PayPalServer.Models;

/// <summary>
/// The details of the captured payment status.
/// </summary>
public record CaptureStatusDetails
{
    /// <summary>
    /// The reason why the captured payment status is <c>PENDING</c> or <c>DENIED</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public CaptureIncompleteReason? Reason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
