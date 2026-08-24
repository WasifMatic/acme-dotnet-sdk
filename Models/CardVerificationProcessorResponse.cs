using System.Text.Json.Serialization;
using PayPalServer.Core.Models;
using PayPalServer.Models.Enums;

namespace PayPalServer.Models;

/// <summary>
/// The processor response information for payment requests, such as direct credit card transactions.
/// </summary>
public record CardVerificationProcessorResponse
{
    /// <summary>
    /// The address verification code for Visa, Discover, Mastercard, or American Express transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avs_code")]
    public AvsCode? AvsCode { get; init; }

    /// <summary>
    /// The card verification value code for for Visa, Discover, Mastercard, or American Express.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvv_code")]
    public CvvCode? CvvCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
