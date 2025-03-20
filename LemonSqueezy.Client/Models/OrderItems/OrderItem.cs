using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.OrderItems
{
    public class OrderItem : ApiObject<OrderItemAttributes>
    {
    }

    public class OrderItemAttributes
    {
        [JsonPropertyName("order_id")]
        public int OrderId { get; set; }

        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("variant_id")]
        public int VariantId { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; } = default!;

        [JsonPropertyName("variant_name")]
        public string VariantName { get; set; } = default!;

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
