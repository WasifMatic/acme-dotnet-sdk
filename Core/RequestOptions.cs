using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using PayPalServer.Core.Hooks;

namespace PayPalServer.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
