using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class EmployeesController : ControllerBase
{
    private readonly ISender _sender;
    private readonly IPublisher _publisher;
    
    public EmployeesController(ISender sender, IPublisher publisher)
    {
        _sender = sender;
        _publisher = publisher;
    }
    
    
}