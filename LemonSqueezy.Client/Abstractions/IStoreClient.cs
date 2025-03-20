using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Stores;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IStoreClient
    {
        Task<Store> GetStoreAsync(string storeId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<Store>> ListStoresAsync(CancellationToken cancellationToken = default);
    }
}
