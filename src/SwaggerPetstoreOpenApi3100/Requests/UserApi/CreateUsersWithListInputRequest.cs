using System.Collections.Generic;
using SwaggerPetstoreOpenApi3100.Models;

namespace SwaggerPetstoreOpenApi3100.Requests.UserApi;

/// <summary>
/// The inputs of the CreateUsersWithListInput operation.
/// </summary>
public sealed record CreateUsersWithListInputRequest
{
    public IReadOnlyList<User>? Body { get; init; }
}
