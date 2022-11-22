using Domain.Entities.Companies;
using Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){ }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Company> Companies { get; set; }
}