using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.LicenseKeys;

namespace LemonSqueezy.Client.Abstractions
{
    public interface ILicenseKeyInstanceClient
    {
        Task<LicenseKeyInstance> GetLicenseKeyInstanceAsync(string instanceId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<LicenseKeyInstance>> ListLicenseKeyInstancesAsync(CancellationToken cancellationToken = default);
    }
}
