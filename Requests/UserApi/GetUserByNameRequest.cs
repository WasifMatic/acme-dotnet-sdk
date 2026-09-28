namespace SwaggerPetstoreOpenApi30.Requests.UserApi;

/// <summary>
/// The inputs of the GetUserByName operation.
/// </summary>
public sealed record GetUserByNameRequest
{
    /// <summary>
    /// The username that needs to be processed
    /// </summary>
    public required string Usersname { get; init; }
}
