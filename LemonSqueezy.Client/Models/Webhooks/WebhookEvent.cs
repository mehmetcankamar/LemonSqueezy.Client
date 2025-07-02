using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Orders;
using LemonSqueezy.Client.Models.Subscriptions;
using LemonSqueezy.Client.Models.SubscriptionInvoices;
using LemonSqueezy.Client.Models.LicenseKeys;
using System.Collections.Generic;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Products;
using System.Text.Json;

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

        [JsonPropertyName("custom_data")]
        public Dictionary<string, string> CustomData { get; set; } = new Dictionary<string, string>();
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
                order = new Order { Id = Id, Attributes = ((JsonElement)Attributes).Deserialize<OrderAttributes>() };
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

                subscription = new Subscription { Id = Id, Attributes = ((JsonElement)Attributes).Deserialize<SubscriptionAttributes>() };
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
                licenseKey = new LicenseKey { Id = Id, Attributes = ((JsonElement)Attributes).Deserialize<LicenseKeyAttributes>() };
                return true;
            }
            catch { return false; }
        }

        public bool TryGetSubscriptionInvoice(out SubscriptionInvoice? subscriptionInvoice)
        {
            subscriptionInvoice = null;
            if (Type != "subscription-invoices") return false;
            try
            {
                subscriptionInvoice = new SubscriptionInvoice { Id = Id, Attributes = ((JsonElement)Attributes).Deserialize<SubscriptionInvoiceAttributes>() };
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
        public const string SubscriptionResumed= "subscription_resumed";
        public const string SubscriptionExpired = "subscription_exprired";
        public const string SubscriptionPaused = "subscription_paused";
        public const string SubscriptionUnpaused = "subscription_unpaused";
        public const string SubscriptionPaymentSuccess = "subscription_payment_success";
        public const string SubscriptionPaymentFailed = "subscription_payment_failed";
        public const string SubscriptionPaymentRecovered = "subscription_payment_recovered";
        public const string SubscriptionPaymentRefunded = "subscription_payment_refunded";
        public const string SubscriptionPlanChanged = "subscription_plan_changed";
        public const string SubscriptionInvoiceCreated = "subscription_invoice_created";
        public const string LicenseKeyCreated = "license_key_created";
        public const string LicenseKeyActivated = "license_key_activated";
        public const string LicenseKeyDeactivated = "license_key_deactivated";
    }
}
