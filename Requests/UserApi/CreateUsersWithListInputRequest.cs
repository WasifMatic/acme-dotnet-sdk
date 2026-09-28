using System.Collections.Generic;
using SwaggerPetstoreOpenApi30.Models;

namespace SwaggerPetstoreOpenApi30.Requests.UserApi;

/// <summary>
/// The inputs of the CreateUsersWithListInput operation.
/// </summary>
public sealed record CreateUsersWithListInputRequest
{
    public IReadOnlyList<User>? Body { get; init; }
}
