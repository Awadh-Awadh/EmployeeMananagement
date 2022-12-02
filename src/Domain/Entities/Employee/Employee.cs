using Domain.Common;

namespace Domain.Entities.Employee;

public class Employee : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Position { get; set; } = string.Empty;
    public int CompanyId { get; set; }
    
    public Company.Company Company { get; set; }
}