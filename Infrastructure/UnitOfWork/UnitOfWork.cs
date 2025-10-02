using System.Threading;
using System.Threading.Tasks;
using CleanShop.Application.Abstractions;
using CleanShop.Infrastructure.Persistence;

namespace CleanShop.Infrastructure.Persistence.Repositories
{
    public sealed class UnitOfWork(AppDbContext db) : IUnitOfWork
    {
        public Task<int> SaveChangesAsync(CancellationToken ct = default)
            => db.SaveChangesAsync(ct);
    }
}
