using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.Customers
{
    public class UpdateCustomerRequest
    {
        public UpdateCustomerData Data { get; set; }

        public UpdateCustomerRequest(string customerId, UpdateCustomerAttributes attributes)
        {
            Data = new UpdateCustomerData
            {
                Type = "customers",
                Id = customerId,
                Attributes = attributes
            };
        }
    }

    public class UpdateCustomerData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "customers";

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public UpdateCustomerAttributes Attributes { get; set; }
    }

    public class UpdateCustomerAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        public UpdateCustomerAttributes(string name, string email)
        {
            Name = name;
            Email = email;
        }

        // Parameterless constructor for deserialization
        public UpdateCustomerAttributes() { }
    }
}
