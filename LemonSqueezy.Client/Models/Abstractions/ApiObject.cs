using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.Abstractions
{
    public abstract class ApiObject<TAttributes> where TAttributes : class
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        [JsonPropertyName("attributes")]
        public TAttributes Attributes { get; set; } = default!;
    }
}
