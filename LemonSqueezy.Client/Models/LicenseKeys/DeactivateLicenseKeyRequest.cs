using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class DeactivateLicenseKeyRequest
    {
        [JsonPropertyName("license_key")]
        public string LicenseKey { get; }

        [JsonPropertyName("instance_name")]
        public string InstanceName { get; }

        public DeactivateLicenseKeyRequest(string licenseKey, string instanceName)
        {
            LicenseKey = licenseKey;
            InstanceName = instanceName;
        }
    }
}
