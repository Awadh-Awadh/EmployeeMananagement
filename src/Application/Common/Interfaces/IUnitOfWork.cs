namespace Application.Common.Interfaces;

public interface IUnitOfWork
{
    public IEmployeeRepository Employee { get; set; }
    public ICompanyRepository Company { get; set; }
    Task CompleteAsync();
}