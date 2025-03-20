using System;
using System.Security.Cryptography;
using System.Text;

namespace LemonSqueezy.Client.Security
{
    public static class WebhookVerification
    {
        /// <summary>
        /// Verifies that the webhook signature is valid.
        /// </summary>
        /// <param name="payload">The raw webhook payload</param>
        /// <param name="signature">The signature from the X-Signature header</param>
        /// <param name="signingSecret">Your webhook signing secret from Lemon Squeezy</param>
        /// <returns>True if the signature is valid, false otherwise</returns>
        public static bool IsValid(string payload, string signature, string signingSecret)
        {
            try
            {
                using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(signingSecret));
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));
                var computedSignature = BitConverter.ToString(hash).Replace("-", "").ToLower();

                return computedSignature == signature.ToLower();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifies that the webhook signature is valid and throws if it isn't.
        /// </summary>
        /// <param name="payload">The raw webhook payload</param>
        /// <param name="signature">The signature from the X-Signature header</param>
        /// <param name="signingSecret">Your webhook signing secret from Lemon Squeezy</param>
        /// <exception cref="InvalidOperationException">Thrown when the signature is invalid</exception>
        public static void EnsureValid(string payload, string signature, string signingSecret)
        {
            if (!IsValid(payload, signature, signingSecret))
            {
                throw new InvalidOperationException("Invalid webhook signature");
            }
        }
    }
}
