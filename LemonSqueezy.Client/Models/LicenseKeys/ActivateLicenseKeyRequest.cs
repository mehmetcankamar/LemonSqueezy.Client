using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class ActivateLicenseKeyRequest
    {
        [JsonPropertyName("license_key")]
        public string LicenseKey { get; }

        [JsonPropertyName("instance_name")]
        public string InstanceName { get; }

        public ActivateLicenseKeyRequest(string licenseKey, string instanceName)
        {
            LicenseKey = licenseKey;
            InstanceName = instanceName;
        }
    }
}
