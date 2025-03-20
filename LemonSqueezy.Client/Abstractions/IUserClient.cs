using System.Threading;
using System.Threading.Tasks;
using LemonSqueezy.Client.Models.Users;

namespace LemonSqueezy.Client.Abstractions
{
    public interface IUserClient
    {
        Task<User> GetCurrentUserAsync(CancellationToken cancellationToken = default);
        Task<User> GetUserAsync(string userId, CancellationToken cancellationToken = default);
    }
}
