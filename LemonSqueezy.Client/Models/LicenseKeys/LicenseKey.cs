using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class LicenseKey : ApiObject<LicenseKeyAttributes>
    {
    }

    public class LicenseKeyAttributes
    {
        [JsonPropertyName("store_id")]
        public int StoreId { get; set; }

        [JsonPropertyName("customer_id")]
        public int CustomerId { get; set; }

        [JsonPropertyName("order_id")]
        public int OrderId { get; set; }

        [JsonPropertyName("order_item_id")]
        public int OrderItemId { get; set; }

        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; } = default!;

        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; } = default!;

        [JsonPropertyName("key")]
        public string Key { get; set; } = default!;

        [JsonPropertyName("key_short")]
        public string KeyShort { get; set; } = default!;

        [JsonPropertyName("activation_limit")]
        public int ActivationLimit { get; set; }

        [JsonPropertyName("instances_count")]
        public int InstancesCount { get; set; }

        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("status_formatted")]
        public string StatusFormatted { get; set; } = default!;

        [JsonPropertyName("expires_at")]
        public DateTimeOffset? ExpiresAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
