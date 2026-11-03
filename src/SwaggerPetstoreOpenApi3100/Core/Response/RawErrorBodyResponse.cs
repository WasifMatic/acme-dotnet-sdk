using System.Threading;
using System.Threading.Tasks;
using SwaggerPetstoreOpenApi3100.Core.ErrorResponse;
using SwaggerPetstoreOpenApi3100.Core.Models;

namespace SwaggerPetstoreOpenApi3100.Core.Response;

internal sealed class RawErrorBodyResponse : IResponse<RawError>
{
    public static RawErrorBodyResponse Instance { get; } = new();

    private RawErrorBodyResponse() { }

    public ValueTask<RawError> Map(ResponseContext context, CancellationToken cancellationToken) =>
        new(RawError.Create(context.Response, cancellationToken));
}
