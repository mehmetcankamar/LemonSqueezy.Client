using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.Customers
{
    public class CreateCustomerRequest
    {
        public CreateCustomerData Data { get; set; }

        public CreateCustomerRequest(CreateCustomerAttributes attributes)
        {
            Data = new CreateCustomerData
            {
                Type = "customers",
                Attributes = attributes
            };
        }
    }

    public class CreateCustomerData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = "customers";

        [JsonPropertyName("attributes")]
        public CreateCustomerAttributes Attributes { get; set; }
    }

    public class CreateCustomerAttributes
    {
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

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

        public CreateCustomerAttributes(string storeId, string name, string email)
        {
            StoreId = storeId;
            Name = name;
            Email = email;
        }

        // Parameterless constructor for deserialization
        public CreateCustomerAttributes() { }
    }
}
