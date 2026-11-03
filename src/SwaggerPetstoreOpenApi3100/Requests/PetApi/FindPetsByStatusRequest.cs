using SwaggerPetstoreOpenApi3100.Models.Enums;

namespace SwaggerPetstoreOpenApi3100.Requests.PetApi;

/// <summary>
/// The inputs of the FindPetsByStatus operation.
/// </summary>
public sealed record FindPetsByStatusRequest
{
    /// <summary>
    /// Status values that need to be considered for filter
    /// </summary>
    public PetStatus? Status { get; init; }
}
