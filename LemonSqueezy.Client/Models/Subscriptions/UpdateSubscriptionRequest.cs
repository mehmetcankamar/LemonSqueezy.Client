using System;

namespace LemonSqueezy.Client.Models.Subscriptions
{
    public class UpdateSubscriptionRequest 
    {
        public int? VariantId { get; set; }
        public PauseCollection? Pause { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime? TrialEndsAt { get; set; }
        public int? BillingAnchor { get; set; }
        public bool? InvoiceImmediately { get; set; }
        public bool? DisableProrations { get; set; }
    }

    internal class UpdateSubscriptionRequestWrapper
    {
        public UpdateSubscriptionData Data { get; }

        public UpdateSubscriptionRequestWrapper(string id, UpdateSubscriptionRequest attributes)
        {
            Data = new UpdateSubscriptionData
            {
                Type = "subscriptions",
                Id = id,
                Attributes = attributes
            };
        }
    }

    internal class UpdateSubscriptionData
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public UpdateSubscriptionRequest Attributes { get; set; }
    }

    public class PauseCollection
    {
        public string Mode { get; set; } // Can be "void" or "free"
        public DateTime? ResumesAt { get; set; }
    }
}
