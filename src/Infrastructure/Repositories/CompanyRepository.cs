using Application.Common.Interfaces;
using Domain.Entities.Company;
using Infrastructure.Persistence;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

public class CompanyRepository :Repository<Company>, ICompanyRepository
{
    public CompanyRepository(ILogger logger, AppDbContext dbContext) : base(logger, dbContext)
    {
    }
}