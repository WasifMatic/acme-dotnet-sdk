using System.Net.Http;

namespace PayPalServer.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}