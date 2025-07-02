using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.SubscriptionInvoices
{
    public class SubscriptionInvoice : ApiObject<SubscriptionInvoiceAttributes>
    {

    }

    public class SubscriptionInvoiceAttributes
    {
        [JsonPropertyName("store_id")]
        public int StoreId { get; set; }

        [JsonPropertyName("subscription_id")]
        public int SubscriptionId { get; set; }

        [JsonPropertyName("customer_id")]
        public int CustomerId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; } = string.Empty;

        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; } = string.Empty;

        [JsonPropertyName("billing_reason")]
        public string BillingReason { get; set; } = string.Empty;

        [JsonPropertyName("card_brand")]
        public string? CardBrand { get; set; }

        [JsonPropertyName("card_last_four")]
        public string? CardLastFour { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("currency_rate")]
        public string CurrencyRate { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonPropertyName("status_formatted")]
        public string StatusFormatted { get; set; } = string.Empty;

        [JsonPropertyName("refunded")]
        public bool Refunded { get; set; }

        [JsonPropertyName("refunded_at")]
        public DateTimeOffset? RefundedAt { get; set; }

        [JsonPropertyName("subtotal")]
        public int Subtotal { get; set; }

        [JsonPropertyName("discount_total")]
        public int DiscountTotal { get; set; }

        [JsonPropertyName("tax")]
        public int Tax { get; set; }

        [JsonPropertyName("tax_inclusive")]
        public bool TaxInclusive { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
        
        [JsonPropertyName("refunded_amount")]
        public int RefundedAmount { get; set; }

        [JsonPropertyName("subtotal_usd")]
        public int SubtotalUsd { get; set; }

        [JsonPropertyName("discount_total_usd")]
        public int DiscountTotalUsd { get; set; }

        [JsonPropertyName("tax_usd")]
        public int TaxUsd { get; set; }

        [JsonPropertyName("total_usd")]
        public int TotalUsd { get; set; }
        
        [JsonPropertyName("refunded_amount_usd")]
        public int RefundedAmountUsd { get; set; }

        [JsonPropertyName("subtotal_formatted")]
        public string SubtotalFormatted { get; set; } = string.Empty;

        [JsonPropertyName("discount_total_formatted")]
        public string DiscountTotalFormatted { get; set; } = string.Empty;

        [JsonPropertyName("tax_formatted")]
        public string TaxFormatted { get; set; } = string.Empty;

        [JsonPropertyName("total_formatted")]
        public string TotalFormatted { get; set; } = string.Empty;
        
        [JsonPropertyName("refunded_amount_formatted")]
        public string RefundedAmountFormatted { get; set; } = string.Empty;

        [JsonPropertyName("urls")]
        public SubscriptionInvoiceUrls Urls { get; set; } = null!;

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }

    public class SubscriptionInvoiceUrls
    {
        [JsonPropertyName("invoice_url")]
        public string InvoiceUrl { get; set; } = string.Empty;
    }
}
