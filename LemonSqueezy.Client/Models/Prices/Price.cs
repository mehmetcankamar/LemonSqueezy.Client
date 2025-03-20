using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Prices
{
    public class Price : ApiObject<PriceAttributes>
    {
    }

    public class PriceAttributes
    {
        [JsonPropertyName("variant_id")]
        public int VariantId { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; } = default!;

        [JsonPropertyName("scheme")]
        public string Scheme { get; set; } = default!;

        [JsonPropertyName("usage_aggregation")]
        public string? UsageAggregation { get; set; }

        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }

        [JsonPropertyName("unit_price_decimal")]
        public decimal? UnitPriceDecimal { get; set; }

        [JsonPropertyName("setup_fee_enabled")]
        public bool SetupFeeEnabled { get; set; }

        [JsonPropertyName("setup_fee")]
        public int? SetupFee { get; set; }

        [JsonPropertyName("package_size")]
        public int PackageSize { get; set; }

        [JsonPropertyName("tiers")]
        public PriceTier[] Tiers { get; set; } = default!;

        [JsonPropertyName("renewal_interval_unit")]
        public string RenewalIntervalUnit { get; set; } = default!;

        [JsonPropertyName("renewal_interval_quantity")]
        public int RenewalIntervalQuantity { get; set; }

        [JsonPropertyName("trial_interval_unit")]
        public string TrialIntervalUnit { get; set; } = default!;

        [JsonPropertyName("trial_interval_quantity")]
        public int TrialIntervalQuantity { get; set; }

        [JsonPropertyName("min_price")]
        public int? MinPrice { get; set; }

        [JsonPropertyName("suggested_price")]
        public int? SuggestedPrice { get; set; }

        [JsonPropertyName("tax_code")]
        public string TaxCode { get; set; } = default!;

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public class PriceTier
    {
        [JsonPropertyName("last_unit")]
        [JsonConverter(typeof(LastUnitConverter))]
        public LastUnit LastUnit { get; set; }

        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }

        [JsonPropertyName("unit_price_decimal")]
        public decimal? UnitPriceDecimal { get; set; }

        [JsonPropertyName("fixed_fee")]
        public int FixedFee { get; set; }
    }

    public class LastUnit
    {
        public bool IsInfinity { get; set; }
        public int? Value { get; set; }
    }

    public class LastUnitConverter : JsonConverter<LastUnit>
    {
        public override LastUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var value = reader.GetString();
                if (value == "inf")
                {
                    return new LastUnit { IsInfinity = true };
                }
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return new LastUnit { IsInfinity = false, Value = reader.GetInt32() };
            }

            throw new JsonException("Invalid LastUnit value");
        }

        public override void Write(Utf8JsonWriter writer, LastUnit value, JsonSerializerOptions options)
        {
            if (value.IsInfinity)
            {
                writer.WriteStringValue("inf");
            }
            else
            {
                writer.WriteNumberValue(value.Value!.Value);
            }
        }
    }
}
