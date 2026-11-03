using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SwaggerPetstoreOpenApi3100.Core.Hooks;
using SwaggerPetstoreOpenApi3100.Core.Models;

namespace SwaggerPetstoreOpenApi3100.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<HeaderParam>? Headers { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
