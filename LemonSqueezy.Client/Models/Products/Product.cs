using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Products
{
    public class Product : ApiObject<ProductAttributes>
    {
    }

    public class ProductAttributes
    {
        [JsonPropertyName("store_id")]
        public int StoreId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("slug")]
        public string Slug { get; set; } = default!;

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("status_formatted")]
        public string StatusFormatted { get; set; } = default!;

        [JsonPropertyName("thumb_url")]
        public string ThumbUrl { get; set; } = default!;

        [JsonPropertyName("large_thumb_url")]
        public string LargeThumbUrl { get; set; } = default!;

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price_formatted")]
        public string PriceFormatted { get; set; } = default!;

        [JsonPropertyName("from_price")]
        public int? FromPrice { get; set; }

        [JsonPropertyName("to_price")]
        public int? ToPrice { get; set; }

        [JsonPropertyName("pay_what_you_want")]
        public bool PayWhatYouWant { get; set; }

        [JsonPropertyName("buy_now_url")]
        public string BuyNowUrl { get; set; } = default!;

        [JsonPropertyName("from_price_formatted")]
        public string? FromPriceFormatted { get; set; }

        [JsonPropertyName("to_price_formatted")]
        public string? ToPriceFormatted { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }
}
