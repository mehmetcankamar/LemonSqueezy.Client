using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class DeactivateLicenseKeyResponse : LicenceKeyResponse
    {
        [JsonPropertyName("deactivated")]
        public bool Deactivated { get; set; }

        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }
}
