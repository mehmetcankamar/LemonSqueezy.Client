using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace LemonSqueezy.Client.Extensions
{
    internal static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PostAsJsonAsync<TValue>(
            this HttpClient client,
            string requestUri,
            TValue value,
            JsonSerializerOptions? options = null,
            CancellationToken cancellationToken = default)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(value, options),
                Encoding.UTF8,
                "application/vnd.api+json");

            return client.PostAsync(requestUri, content, cancellationToken);
        }

        public static Task<HttpResponseMessage> PatchAsJsonAsync<TValue>(
            this HttpClient client,
            string requestUri,
            TValue value,
            JsonSerializerOptions? options = null,
            CancellationToken cancellationToken = default)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = new StringContent(
                    JsonSerializer.Serialize(value, options),
                    Encoding.UTF8,
                    "application/vnd.api+json")
            };

            return client.SendAsync(request, cancellationToken);
        }
    }
}
