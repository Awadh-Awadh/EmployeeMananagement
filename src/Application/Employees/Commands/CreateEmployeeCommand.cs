using Application.Common.Interfaces;
using Application.Employee.Commands.DTOs;
using MediatR;

namespace Application.Employee.Commands;

public sealed record CreatePersonCommand(CreateEmployeeDto EmployeeDto) : IRequest<Domain.Entities.Employee.Employee>;

public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, Domain.Entities.Employee.Employee>
{
    private readonly IUnitOfWork _unitOfWork;
    
    public CreatePersonCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<Domain.Entities.Employee.Employee> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        var employee = new Domain.Entities.Employee.Employee()
        {
            Name = request.EmployeeDto.Name,
            Age = request.EmployeeDto.Age,
            Position = request.EmployeeDto.Position,
            CompanyId = request.EmployeeDto.CompanyId
        };
        await _unitOfWork.Employee.CreateAsync(employee);

        return employee;
    }
};