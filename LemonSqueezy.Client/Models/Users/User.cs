using System;
using System.Text.Json.Serialization;
using LemonSqueezy.Client.Models.Abstractions;

namespace LemonSqueezy.Client.Models.Users
{
    public class User : ApiObject<UserAttributes>
    {
    }

    public class UserAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        [JsonPropertyName("color")]
        public string Color { get; set; } = default!;

        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; } = default!;

        [JsonPropertyName("has_custom_avatar")]
        public bool HasCustomAvatar { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
