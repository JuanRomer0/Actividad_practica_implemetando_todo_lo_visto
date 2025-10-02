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
    public sealed class CompanyRepository(AppDbContext db) : ICompanyRepository
    {
        public Task<Company?> GetByIdAsync(Guid id, CancellationToken ct = default)
            => db.Companies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, ct);

        public async Task AddAsync(Company company, CancellationToken ct = default)
        {
            db.Companies.Add(company);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Company company, CancellationToken ct = default)
        {
            db.Companies.Update(company);
            await Task.CompletedTask;
        }

        public async Task RemoveAsync(Company company, CancellationToken ct = default)
        {
            db.Companies.Remove(company);
            await db.SaveChangesAsync(ct);
        }

        public async Task<IReadOnlyList<Company>> GetAllAsync(CancellationToken ct = default)
        {
            return await db.Companies
                .AsNoTracking()
                .OrderBy(c => c.Name)
                .ToListAsync(ct);
        }
    }
}
