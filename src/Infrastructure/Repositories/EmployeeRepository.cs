using Application.Common.Interfaces;
using Domain.Entities.Employees;
using Infrastructure.Persistence;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

public class EmployeeRepository :Repository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(ILogger logger, AppDbContext dbContext) : base(logger, dbContext)
    {
    }
}