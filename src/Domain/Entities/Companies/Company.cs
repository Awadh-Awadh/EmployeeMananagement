using Domain.Common;
using Domain.Entities.Employees;

namespace Domain.Entities.Companies;

public class Company : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public ICollection<Employee> Employees { get; set; }
}