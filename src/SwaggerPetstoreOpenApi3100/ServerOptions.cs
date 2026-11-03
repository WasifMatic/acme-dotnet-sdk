using SwaggerPetstoreOpenApi3100.Servers;

namespace SwaggerPetstoreOpenApi3100;

public class ServerOptions
{
    public DefaultOptions Default { get; set; } = new();
    public AuthServerOptions AuthServer { get; set; } = new();
}
