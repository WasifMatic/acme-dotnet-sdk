using System.Net.Http;

namespace SwaggerPetstoreOpenApi3100.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}
