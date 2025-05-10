using System;
using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.LicenseKeys
{
    public class LicenceKeyResponse
    {
        [JsonPropertyName("license_key")]
        public LicenseKeyAttributes? LicenseKey { get; set; }

        [JsonPropertyName("instance")]
        public LicenceKeyInstance? Instance { get; set; }

        [JsonPropertyName("meta")]
        public LicenceKeyMeta? Meta { get; set; }
    }

    public class LicenceKeyInstance
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }

    public class LicenceKeyMeta
    {
        [JsonPropertyName("store_id")]
        public long StoreId { get; set; }

        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        [JsonPropertyName("product_name")]
        public string? ProductName { get; set; }

        [JsonPropertyName("variant_id")]
        public long VariantId { get; set; }

        [JsonPropertyName("variant_name")]
        public string? VariantName { get; set; }

        [JsonPropertyName("customer_id")]
        public long CustomerId { get; set; }

        [JsonPropertyName("customer_name")]
        public string? CustomerName { get; set; }

        [JsonPropertyName("customer_email")]
        public string? CustomerEmail { get; set; }
    }
}
