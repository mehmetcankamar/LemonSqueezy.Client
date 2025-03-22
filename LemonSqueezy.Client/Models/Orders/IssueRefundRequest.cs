using System.Text.Json.Serialization;

namespace LemonSqueezy.Client.Models.Orders
{
    public class IssueRefundRequest
    {
        public IssueRefundRequest(string orderId, int amount)
        {
            Data = new IssueRefundRequestData
            {
                Type = "orders",
                Id = orderId,
                Attributes = new IssueRefundAttributes
                {
                    Amount = amount
                }
            };
        }

        [JsonPropertyName("data")]
        public IssueRefundRequestData Data { get; set; }
    }

    public class IssueRefundRequestData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attributes")]
        public IssueRefundAttributes Attributes { get; set; }
    }

    public class IssueRefundAttributes
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
