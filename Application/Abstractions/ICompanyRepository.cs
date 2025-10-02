using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CleanShop.Domain.Entities;

namespace CleanShop.Application.Abstractions
{
    public interface ICompanyRepository
    {
        Task<Company?> GetByIdAsync(Guid id, CancellationToken ct = default);
        Task AddAsync(Company company, CancellationToken ct = default);
        Task UpdateAsync(Company company, CancellationToken ct = default);
        Task RemoveAsync(Company company, CancellationToken ct = default);
        Task<IReadOnlyList<Company>> GetAllAsync(CancellationToken ct = default);
    }
}
