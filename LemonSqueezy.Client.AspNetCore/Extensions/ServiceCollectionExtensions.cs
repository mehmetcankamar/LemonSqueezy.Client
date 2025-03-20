using System;
using LemonSqueezy.Client.Abstractions;
using LemonSqueezy.Client.Configuration;
using LemonSqueezy.Client.Internal.HttpClients;
using Microsoft.Extensions.DependencyInjection;


namespace LemonSqueezy.Client.AspNetCore.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add Lemon Squeezy webhook handling services.
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="signingSecret">Your webhook signing secret from Lemon Squeezy</param>
        /// <returns>The service collection for chaining</returns>
        public static IServiceCollection AddLemonSqueezyWebhooks(this IServiceCollection services, string signingSecret)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrEmpty(signingSecret)) throw new ArgumentException("Signing secret cannot be empty", nameof(signingSecret));

            services.AddSingleton(new WebhookOptions { SigningSecret = signingSecret });
            return services;
        }

        public static IServiceCollection AddLemonSqueezy(this IServiceCollection services, Action<LemonSqueezyOptions> configure)
        {
            var options = new LemonSqueezyOptions();
            configure(options);
            services.AddSingleton(options);
         
            services.AddHttpClient<ILemonSqueezyClient, LemonSqueezyHttpClient>()
                .ConfigureHttpClient((provider, client) =>
                {
                    var squeezyOptions = provider.GetRequiredService<LemonSqueezyOptions>();
                    client.BaseAddress = new Uri(squeezyOptions.BaseUrl);
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", squeezyOptions.ApiKey);
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.api+json"));
                });

            return services;
        }

        public static IServiceCollection AddLemonSqueezy(this IServiceCollection services, string apiKey)
        {
            return services.AddLemonSqueezy(options => options.ApiKey = apiKey);
        }
    }

    public class WebhookOptions
    {
        public string SigningSecret { get; set; } = default!;
    }
}
