using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Orders;
using LemonSqueezy.Client.Models.Subscriptions;
using LemonSqueezy.Client.Models.LicenseKeys;

namespace LemonSqueezy.Client.Models.Webhooks
{
    public class WebhookEvent
    {
        [JsonPropertyName("meta")]
        public WebhookMeta Meta { get; set; } = default!;

        [JsonPropertyName("data")]
        public WebhookData Data { get; set; } = default!;
    }

    public class WebhookMeta
    {
        [JsonPropertyName("event_name")]
        public string EventName { get; set; } = default!;

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }

    public class WebhookData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        [JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        public bool TryGetOrder(out Order? order)
        {
            order = null;
            if (Type != "orders") return false;
            try
            {
                order = new Order { Id = Id, Attributes = (OrderAttributes)Attributes! };
                return true;
            }
            catch { return false; }
        }

        public bool TryGetSubscription(out Subscription? subscription)
        {
            subscription = null;
            if (Type != "subscriptions") return false;
            try
            {
                subscription = new Subscription { Id = Id, Attributes = (SubscriptionAttributes)Attributes! };
                return true;
            }
            catch { return false; }
        }

        public bool TryGetLicenseKey(out LicenseKey? licenseKey)
        {
            licenseKey = null;
            if (Type != "license-keys") return false;
            try
            {
                licenseKey = new LicenseKey { Id = Id, Attributes = (LicenseKeyAttributes)Attributes! };
                return true;
            }
            catch { return false; }
        }
    }

    public static class WebhookEventNames
    {
        public const string OrderCreated = "order_created";
        public const string OrderRefunded = "order_refunded";
        public const string SubscriptionCreated = "subscription_created";
        public const string SubscriptionUpdated = "subscription_updated";
        public const string SubscriptionCancelled = "subscription_cancelled";
        public const string SubscriptionPaymentSuccess = "subscription_payment_success";
        public const string SubscriptionPaymentFailed = "subscription_payment_failed";
        public const string SubscriptionPaymentRecovered = "subscription_payment_recovered";
        public const string LicenseKeyCreated = "license_key_created";
        public const string LicenseKeyActivated = "license_key_activated";
        public const string LicenseKeyDeactivated = "license_key_deactivated";
    }
}
