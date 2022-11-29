using Application.Common.Interfaces;
using Domain.Entities.Companies;
using Domain.Entities.Employees;
using Infrastructure.Repositories;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ILogger _logger;
    private readonly AppDbContext _context;
    
    public UnitOfWork(ILoggerFactory logger, AppDbContext context)
    {
        // Make sure the logger is created.
        _logger = logger.CreateLogger("logs") ;
        _context = context;
        Employee = new EmployeeRepository(_logger, _context);
        Company = new CompanyRepository(_logger, _context);
    }
    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    
    public IEmployeeRepository Employee { get; set; }
    public ICompanyRepository Company { get; set; }
}