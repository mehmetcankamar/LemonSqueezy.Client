using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.LicenseKeys;

namespace LemonSqueezy.Client.Abstractions
{
    public interface ILicenseKeyClient
    {
        Task<LicenseKey> GetLicenseKeyAsync(string licenseKeyId, CancellationToken cancellationToken = default);
      Task<ApiResponseList<LicenseKey>> ListLicenseKeysAsync(CancellationToken cancellationToken = default);
        Task<ActivateLicenseKeyResponse> ActivateLicenseKeyAsync(string key, string instance, CancellationToken cancellationToken = default);
        Task<DeactivateLicenseKeyResponse> DeactivateLicenseKeyAsync(string key, string instance, CancellationToken cancellationToken = default);
        Task<bool> ValidateLicenseKeyAsync(string key, string instance, CancellationToken cancellationToken = default);
    }
}
