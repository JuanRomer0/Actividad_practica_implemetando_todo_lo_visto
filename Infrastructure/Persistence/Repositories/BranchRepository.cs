using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CleanShop.Application.Abstractions;
using CleanShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanShop.Infrastructure.Persistence.Repositories
{
    public sealed class BranchRepository(AppDbContext db) : IBranchRepository
    {
        public Task<Branch?> GetByIdAsync(Guid id, CancellationToken ct = default)
            => db.Branches.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id, ct);

        public async Task AddAsync(Branch branch, CancellationToken ct = default)
        {
            db.Branches.Add(branch);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Branch branch, CancellationToken ct = default)
        {
            db.Branches.Update(branch);
            await Task.CompletedTask;
        }

        public async Task RemoveAsync(Branch branch, CancellationToken ct = default)
        {
            db.Branches.Remove(branch);
            await db.SaveChangesAsync(ct);
        }

        public async Task<IReadOnlyList<Branch>> GetByCompanyAsync(Guid companyId, CancellationToken ct = default)
        {
            return await db.Branches
                .AsNoTracking()
                .Where(b => b.CompanyId == companyId)
                .OrderBy(b => b.NumberComercial)
                .ToListAsync(ct);
        }
    }
}
