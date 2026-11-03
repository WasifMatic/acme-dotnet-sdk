using System.Net.Http;

namespace SwaggerPetstoreOpenApi3100.Core.Extensions;

internal static class HttpContentExtension
{
    extension(HttpContent)
    {
        public static HttpContent None => null!;
    }
}
