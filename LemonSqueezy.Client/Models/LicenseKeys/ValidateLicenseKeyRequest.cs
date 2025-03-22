using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class ValidateLicenseKeyRequest
    {
        [JsonPropertyName("license_key")]
        public string LicenseKey { get; }

        [JsonPropertyName("instance_name")]
        public string InstanceName { get; }

        public ValidateLicenseKeyRequest(string licenseKey, string instanceName)
        {
            LicenseKey = licenseKey;
            InstanceName = instanceName;
        }
    }
}
