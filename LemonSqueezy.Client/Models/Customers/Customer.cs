using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Customers
{
    public class Customer : ApiObject<CustomerAttributes>
    {
    }

    public class CustomerAttributes
    {
        [JsonPropertyName("store_id")]
        public int StoreId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; } = default!;

        [JsonPropertyName("total_revenue_currency")]
        public int TotalRevenueCurrency { get; set; }

        [JsonPropertyName("mrr")]
        public int Mrr { get; set; }

        [JsonPropertyName("status_formatted")]
        public string StatusFormatted { get; set; } = default!;

        [JsonPropertyName("country_formatted")]
        public string CountryFormatted { get; set; } = default!;

        [JsonPropertyName("total_revenue_currency_formatted")]
        public string TotalRevenueCurrencyFormatted { get; set; } = default!;

        [JsonPropertyName("mrr_formatted")]
        public string MrrFormatted { get; set; } = default!;

        [JsonPropertyName("urls")]
        public CustomerUrls Urls { get; set; } = default!;

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }

    public class CustomerUrls
    {
        [JsonPropertyName("customer_portal")]
        public string CustomerPortal { get; set; } = default!;
    }
}
