using Domain.Common;
using Domain.Entities.Companies;


namespace Domain.Entities.Employees;

public class Employee : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Position { get; set; } = string.Empty;
    public int CompanyId { get; set; }
    public Company Company { get; set; }
}