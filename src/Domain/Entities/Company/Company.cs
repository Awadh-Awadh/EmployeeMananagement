using Domain.Common;

namespace Domain.Entities.Company;

public class Company : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public ICollection<Employee.Employee> Employees { get; set; }
}