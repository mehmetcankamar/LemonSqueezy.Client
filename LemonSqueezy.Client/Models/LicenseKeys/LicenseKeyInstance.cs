using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class LicenseKeyInstance : ApiObject<LicenseKeyInstanceAttributes>
    {
    }

    public class LicenseKeyInstanceAttributes
    {
        [JsonPropertyName("license_key_id")]
        public int LicenseKeyId { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
