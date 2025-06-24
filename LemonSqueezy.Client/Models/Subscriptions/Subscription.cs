using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Subscriptions
{
    public class Subscription : ApiObject<SubscriptionAttributes>
    {
    }

    public class SubscriptionAttributes
    {
        [JsonPropertyName("store_id")]
        public int StoreId { get; set; }

        [JsonPropertyName("subscription_id")]
        public int SubscriptionId { get; set; }

        [JsonPropertyName("customer_id")]
        public int CustomerId { get; set; }

        [JsonPropertyName("order_id")]
        public int OrderId { get; set; }

        [JsonPropertyName("order_item_id")]
        public int OrderItemId { get; set; }

        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("variant_id")]
        public int VariantId { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; } = default!;

        [JsonPropertyName("variant_name")]
        public string VariantName { get; set; } = default!;

        [JsonPropertyName("user_name")]
        public string UserName { get; set; } = default!;

        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; } = default!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("status_formatted")]
        public string StatusFormatted { get; set; } = default!;

        [JsonPropertyName("card_brand")]
        public string CardBrand { get; set; } = default!;

        [JsonPropertyName("card_last_four")]
        public string CardLastFour { get; set; } = default!;

        [JsonPropertyName("pause")]
        public object? Pause { get; set; }

        [JsonPropertyName("cancelled")]
        public bool Cancelled { get; set; }

        [JsonPropertyName("trial_ends_at")]
        public DateTimeOffset? TrialEndsAt { get; set; }

        [JsonPropertyName("billing_anchor")]
        public int BillingAnchor { get; set; }

        [JsonPropertyName("first_subscription_item")]
        public FirstSubscriptionItem FirstSubscriptionItem { get; set; } = default!;

        [JsonPropertyName("urls")]
        public SubscriptionUrls Urls { get; set; } = default!;

        [JsonPropertyName("renews_at")]
        public DateTimeOffset RenewsAt { get; set; }

        [JsonPropertyName("ends_at")]
        public DateTimeOffset? EndsAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }

    public class FirstSubscriptionItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("subscription_id")]
        public int SubscriptionId { get; set; }

        [JsonPropertyName("price_id")]
        public int PriceId { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public class SubscriptionUrls
    {
        [JsonPropertyName("update_payment_method")]
        public string UpdatePaymentMethod { get; set; } = default!;

        [JsonPropertyName("customer_portal")]
        public string CustomerPortal { get; set; } = default!;

        [JsonPropertyName("customer_portal_update_subscription")]
        public string CustomerPortalUpdateSubscription { get; set; } = default!;
    }
}
