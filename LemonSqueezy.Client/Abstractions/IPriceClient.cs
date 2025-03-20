using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Prices;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IPriceClient
    {
        Task<Price> GetPriceAsync(string priceId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<Price>> ListPricesAsync(CancellationToken cancellationToken = default);
    }
}
