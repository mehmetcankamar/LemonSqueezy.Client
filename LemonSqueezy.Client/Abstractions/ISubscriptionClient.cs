using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Subscriptions;

namespace LemonSqueezy.Client.Abstractions
{
    public interface ISubscriptionClient
    {
        Task<Subscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<Subscription>> ListSubscriptionsAsync(CancellationToken cancellationToken = default);
        Task<Subscription> UpdateSubscriptionAsync(string subscriptionId, string attributes, CancellationToken cancellationToken = default);
        Task<Subscription> CancelSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);
    }
}
