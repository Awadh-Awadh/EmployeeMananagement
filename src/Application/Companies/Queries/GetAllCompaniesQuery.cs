using Application.Common.Interfaces;
using Application.Companies.Queries.DTOs;
using MediatR;

namespace Application.Companies.Queries;

public sealed record GetAllCompaniesQuery : IRequest<IEnumerable<CompanyGetDto>>;

public class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, IEnumerable<CompanyGetDto>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllCompaniesQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<CompanyGetDto>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _unitOfWork.Company.FindAll(false);

        var companyDtos = companies.Select(c => 
                new CompanyGetDto(c.Id, c.Name, string.Join(' ', c.Address, c.Country))).ToList();
        
        return companyDtos;
    }
}
