using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Customers;

namespace LemonSqueezy.Client.Abstractions
{
    public interface ICustomerClient
    {
        Task<Customer> CreateCustomerAsync(string storeId, string name, string email, CancellationToken cancellationToken = default);
        Task<Customer> CreateCustomerAsync(CreateCustomerAttributes attributes, CancellationToken cancellationToken = default);
        Task<Customer> GetCustomerAsync(string customerId, CancellationToken cancellationToken = default);
        Task<Customer> UpdateCustomerAsync(string customerId, string name, string email, CancellationToken cancellationToken = default);
        Task<Customer> UpdateCustomerAsync(string customerId, UpdateCustomerAttributes attributes, CancellationToken cancellationToken = default);
        Task<ApiResponseList<Customer>> ListCustomersAsync(CancellationToken cancellationToken = default);
    }
}
