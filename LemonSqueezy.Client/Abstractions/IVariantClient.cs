using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Variants;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IVariantClient
    {
        Task<Variant> GetVariantAsync(string variantId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<Variant>> ListVariantsAsync(CancellationToken cancellationToken = default);
    }
}
