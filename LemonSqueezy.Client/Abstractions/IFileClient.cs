using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Abstractions;
using LemonSqueezy.Client.Models.Files;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IFileClient
    {
        Task<LemonFile> GetFileAsync(string fileId, CancellationToken cancellationToken = default);
        Task<ApiResponseList<LemonFile>> ListFilesAsync(CancellationToken cancellationToken = default);
    }
}
