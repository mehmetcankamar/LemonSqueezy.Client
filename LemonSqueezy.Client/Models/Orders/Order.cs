using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Orders
{
    public class Order : ApiObject<OrderAttributes>
    {
    }

    public class OrderAttributes
    {
        [JsonPropertyName("store_id")]
        public int StoreId { get; set; }

        [JsonPropertyName("customer_id")]
        public int CustomerId { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; } = default!;

        [JsonPropertyName("order_number")]
        public int OrderNumber { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; } = default!;

        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; } = default!;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = default!;

        [JsonPropertyName("currency_rate")]
        public string CurrencyRate { get; set; } = default!;

        [JsonPropertyName("subtotal")]
        public int Subtotal { get; set; }

        [JsonPropertyName("setup_fee")]
        public int SetupFee { get; set; }

        [JsonPropertyName("discount_total")]
        public int DiscountTotal { get; set; }

        [JsonPropertyName("tax")]
        public int Tax { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("subtotal_usd")]
        public int SubtotalUsd { get; set; }

        [JsonPropertyName("setup_fee_usd")]
        public int SetupFeeUsd { get; set; }

        [JsonPropertyName("discount_total_usd")]
        public int DiscountTotalUsd { get; set; }

        [JsonPropertyName("tax_usd")]
        public int TaxUsd { get; set; }

        [JsonPropertyName("total_usd")]
        public int TotalUsd { get; set; }

        [JsonPropertyName("tax_name")]
        public string TaxName { get; set; } = default!;

        [JsonPropertyName("tax_rate")]
        public string TaxRate { get; set; } = default!;

        [JsonPropertyName("tax_inclusive")]
        public bool TaxInclusive { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("status_formatted")]
        public string StatusFormatted { get; set; } = default!;

        [JsonPropertyName("refunded")]
        public bool Refunded { get; set; }

        [JsonPropertyName("refunded_at")]
        public DateTimeOffset? RefundedAt { get; set; }

        [JsonPropertyName("subtotal_formatted")]
        public string SubtotalFormatted { get; set; } = default!;

        [JsonPropertyName("setup_fee_formatted")]
        public string SetupFeeFormatted { get; set; } = default!;

        [JsonPropertyName("discount_total_formatted")]
        public string DiscountTotalFormatted { get; set; } = default!;

        [JsonPropertyName("tax_formatted")]
        public string TaxFormatted { get; set; } = default!;

        [JsonPropertyName("total_formatted")]
        public string TotalFormatted { get; set; } = default!;

        [JsonPropertyName("first_order_item")]
        public FirstOrderItem FirstOrderItem { get; set; } = default!;

        [JsonPropertyName("urls")]
        public OrderUrls Urls { get; set; } = default!;

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }

    public class FirstOrderItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

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

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }

    public class OrderUrls
    {
        [JsonPropertyName("receipt")]
        public string Receipt { get; set; } = default!;
    }
}
