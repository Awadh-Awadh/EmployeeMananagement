namespace Application.Employee.Commands.DTOs;

public record CreateEmployeeDto
{
    public string Name { get; init; } = default!;
    public int Age { get; init; }
    public string Position { get; init; } = default!;
    public int CompanyId { get; init; }
}