using System.Threading;
using System.Threading.Tasks;

namespace CleanShop.Application.Abstractions
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken ct = default);
    }
}
