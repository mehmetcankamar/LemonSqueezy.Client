using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Webhooks;
using LemonSqueezy.Client.Security;
using Microsoft.AspNetCore.Http;


namespace LemonSqueezy.Client.AspNetCore.Extensions
{
    public static class WebhookExtensions
    {
        /// <summary>
        /// Reads and verifies a Lemon Squeezy webhook event from the request.
        /// </summary>
        /// <param name="request">The HTTP request containing the webhook</param>
        /// <param name="signingSecret">Your webhook signing secret from Lemon Squeezy</param>
        /// <returns>The parsed webhook event</returns>
        /// <exception cref="InvalidOperationException">Thrown when the webhook signature is invalid</exception>
        public static async Task<WebhookEvent> ReadWebhookAsync(this HttpRequest request, string signingSecret)
        {
            var signature = request.Headers["X-Signature"].ToString();
            if (string.IsNullOrEmpty(signature))
            {
                throw new InvalidOperationException("X-Signature header is missing");
            }

            string payload;
            using (var reader = new StreamReader(request.Body, Encoding.UTF8))
            {
                payload = await reader.ReadToEndAsync();
            }

            WebhookVerification.EnsureValid(payload, signature, signingSecret);

            var webhookEvent = JsonSerializer.Deserialize<WebhookEvent>(payload, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return webhookEvent ?? throw new InvalidOperationException("Failed to deserialize webhook event");
        }

        /// <summary>
        /// Determines if the webhook event is of the specified type.
        /// </summary>
        /// <param name="webhookEvent">The webhook event to check</param>
        /// <param name="eventName">The event name to compare against</param>
        /// <returns>True if the event matches, false otherwise</returns>
        public static bool IsEventType(this WebhookEvent webhookEvent, string eventName)
        {
            return string.Equals(webhookEvent.Meta.EventName, eventName, StringComparison.OrdinalIgnoreCase);
        }
    }
}
