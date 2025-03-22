using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Orders;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IOrderClient
    {
        Task<Order> GetOrderAsync(string orderId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<Order>> ListOrdersAsync(CancellationToken cancellationToken = default);
        Task<byte[]> GenerateInvoiceAsync(string orderId, CancellationToken cancellationToken = default);
        Task<Order> IssueRefundAsync(string orderId, int amount, CancellationToken cancellationToken = default);
    }
}
