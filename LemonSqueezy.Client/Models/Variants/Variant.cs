using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Variants
{
    public class Variant : ApiObject<VariantAttributes>
    {
    }

    public class VariantAttributes
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("slug")]
        public string Slug { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("is_subscription")]
        public bool IsSubscription { get; set; }

        [JsonPropertyName("interval")]
        public string? Interval { get; set; }

        [JsonPropertyName("interval_count")]
        public int? IntervalCount { get; set; }

        [JsonPropertyName("has_free_trial")]
        public bool HasFreeTrial { get; set; }

        [JsonPropertyName("trial_interval")]
        public string TrialInterval { get; set; } = default!;

        [JsonPropertyName("trial_interval_count")]
        public int TrialIntervalCount { get; set; }

        [JsonPropertyName("pay_what_you_want")]
        public bool PayWhatYouWant { get; set; }

        [JsonPropertyName("min_price")]
        public int MinPrice { get; set; }

        [JsonPropertyName("suggested_price")]
        public int SuggestedPrice { get; set; }

        [JsonPropertyName("has_license_keys")]
        public bool HasLicenseKeys { get; set; }

        [JsonPropertyName("license_activation_limit")]
        public int LicenseActivationLimit { get; set; }

        [JsonPropertyName("is_license_limit_unlimited")]
        public bool IsLicenseLimitUnlimited { get; set; }

        [JsonPropertyName("license_length_value")]
        public int LicenseLengthValue { get; set; }

        [JsonPropertyName("license_length_unit")]
        public string LicenseLengthUnit { get; set; } = default!;

        [JsonPropertyName("is_license_length_unlimited")]
        public bool IsLicenseLengthUnlimited { get; set; }

        [JsonPropertyName("sort")]
        public int Sort { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("status_formatted")]
        public string StatusFormatted { get; set; } = default!;

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }
}
