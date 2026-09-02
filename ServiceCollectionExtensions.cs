using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PayPalServer;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddPayPalServerClient(Action<PayPalServerClientOptions>? configure = null)
        {
            var options = new PayPalServerClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddSingleton(sp =>
                {
                    options.Logging =
                        options.Logging with
                        {
                            LoggerFactory = options.Logging.LoggerFactory ?? sp.GetService<ILoggerFactory>()
                        };
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new PayPalServerClient(httpClient, options);
                });
            return services;
        }
    }
}
