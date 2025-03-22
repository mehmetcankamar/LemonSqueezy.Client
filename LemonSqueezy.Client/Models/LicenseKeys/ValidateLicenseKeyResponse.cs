using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class ValidateLicenseKeyResponse
    {
        [JsonPropertyName("valid")]
        public bool Valid { get; set; }

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }
}
