using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CleanShop.Domain.Entities;

namespace CleanShop.Application.Abstractions
{
    public interface IBranchRepository
    {
        Task<Branch?> GetByIdAsync(Guid id, CancellationToken ct = default);
        Task AddAsync(Branch branch, CancellationToken ct = default);
        Task UpdateAsync(Branch branch, CancellationToken ct = default);
        Task RemoveAsync(Branch branch, CancellationToken ct = default);
        Task<IReadOnlyList<Branch>> GetByCompanyAsync(Guid companyId, CancellationToken ct = default);
    }
}
