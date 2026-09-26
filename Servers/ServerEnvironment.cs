using System;
using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi30.Core.Enum;

namespace SwaggerPetstoreOpenApi30.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public sealed record ServerEnvironment : ClosedStringEnum<ServerEnvironment>
{
    private ServerEnvironment(string value) : base(value)
    {
    }

    public static readonly ServerEnvironment Production = new("production");

    public static ServerEnvironment Default() => Production;

    internal TResult Match<TResult>(Func<TResult> onProduction) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ => throw new InvalidOperationException($"{nameof(ServerEnvironment)} holds no known value.")
        };
}
