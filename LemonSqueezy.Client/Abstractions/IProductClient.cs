using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Products;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IProductClient
    {
        Task<Product> GetProductAsync(string productId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<Product>> ListProductsAsync(CancellationToken cancellationToken = default);
    }
}
