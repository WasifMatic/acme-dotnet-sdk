using PayPalServer.Core;
using PayPalServer.Core.Authentication;
using PayPalServer.Core.Authentication.OAuth2;
using PayPalServer.Core.Authentication.OAuth2.ClientCredentials;

namespace PayPalServer;

internal sealed class AuthSchemes
{
    public IAuthScheme Oauth2 { get; }

    public AuthSchemes(PayPalServerClientOptions options, Server server, RawClient rawClient)
    {
        Oauth2 =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(options.Oauth2,
                options.Oauth2TokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForBasicAuthRequest(server.Default("/v1/oauth2/token"), rawClient));
    }
}
