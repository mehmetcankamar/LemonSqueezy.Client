using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class ActivateLicenseKeyResponse : LicenceKeyResponse
    {
        [JsonPropertyName("activated")]
        public bool Activated { get; set; }

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }
}
