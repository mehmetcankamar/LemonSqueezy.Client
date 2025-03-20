using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Files
{
    public class LemonFile : ApiObject<LemonFileAttributes>
    {
    }

    public class LemonFileAttributes
    {
        [JsonPropertyName("variant_id")]
        public int VariantId { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; } = default!;

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("extension")]
        public string Extension { get; set; } = default!;

        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("size_formatted")]
        public string SizeFormatted { get; set; } = default!;

        [JsonPropertyName("version")]
        public string Version { get; set; } = default!;

        [JsonPropertyName("sort")]
        public int Sort { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        [JsonPropertyName("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("test_mode")]
        public bool TestMode { get; set; }
    }
}
