using System;
using SwaggerPetstoreOpenApi30.Core.Models;

namespace SwaggerPetstoreOpenApi30.Core.Exceptions;

public sealed class SdkTimeoutException(string message, Exception? innerException = null)
    : SdkConnectionException(message, innerException)
{
    public required TimeSpan Timeout { get; init; }

    internal static SdkTimeoutException For(CallContext call, TimeSpan timeout, string message, Exception? innerException = null) =>
        new(message, innerException)
        {
            Method = call.Method,
            RequestUri = call.RequestUri,
            Timeout = timeout,
        };
}
