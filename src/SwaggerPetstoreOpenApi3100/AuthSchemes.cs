using SwaggerPetstoreOpenApi3100.Core;
using SwaggerPetstoreOpenApi3100.Core.Authentication;
using SwaggerPetstoreOpenApi3100.Core.Authentication.ApiKey;

namespace SwaggerPetstoreOpenApi3100;

internal sealed class AuthSchemes
{
    public IAuthScheme PetstoreAuth { get; }
    public IAuthScheme ApiKey { get; }

    public AuthSchemes(SwaggerPetstoreOpenApi3100ClientOptions options)
    {
        PetstoreAuth =
            ApiKeyHeaderScheme.Create(
                "PetstoreAuth",
                "Authorization",
                options.PetstoreAuthProvider,
                options.PetstoreAuth ?? EnvironmentVariables.Get("SWAGGER_PETSTORE_OPEN_API3100_PETSTORE_AUTH"));
        ApiKey =
            ApiKeyHeaderScheme.Create(
                "ApiKey",
                "api_key",
                options.ApiKeyProvider,
                options.ApiKey ?? EnvironmentVariables.Get("SWAGGER_PETSTORE_OPEN_API3100_API_KEY"));
    }
}
