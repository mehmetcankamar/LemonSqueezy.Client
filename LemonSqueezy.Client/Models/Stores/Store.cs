using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Stores
{
    public class Store : ApiObject<StoreAttributes>
    {
    }

    public class StoreAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("slug")]
        public string Slug { get; set; } = default!;

        [JsonPropertyName("domain")]
        public string Domain { get; set; } = default!;

        [JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; } = default!;

        [JsonPropertyName("plan")]
        public string Plan { get; set; } = default!;

        [JsonPropertyName("country")]
        public string Country { get; set; } = default!;

        [JsonPropertyName("country_nicename")]
        public string CountryNicename { get; set; } = default!;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = default!;

        [JsonPropertyName("total_sales")]
        public int TotalSales { get; set; }

        [JsonPropertyName("total_revenue")]
        public int TotalRevenue { get; set; }

        [JsonPropertyName("thirty_day_sales")]
        public int ThirtyDaySales { get; set; }

        [JsonPropertyName("thirty_day_revenue")]
        public int ThirtyDayRevenue { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
