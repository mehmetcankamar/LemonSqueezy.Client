using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.OrderItems;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IOrderItemClient
    {
        Task<OrderItem> GetOrderItemAsync(string orderItemId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<OrderItem>> ListOrderItemsAsync(CancellationToken cancellationToken = default);
    }
}
