using Application.Companies.Queries;
using Domain.Entities.Company;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CompaniesController : Controller
{
    private readonly ISender _sender;
    private readonly IPublisher _publisher;
    private readonly ILogger<CompaniesController> _logger;

    public CompaniesController(ISender sender, IPublisher publisher, ILogger<CompaniesController> logger)
    {
        _sender = sender;
        _publisher = publisher;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
    {
        try
        {
            var query = new GetAllCompaniesQuery();
            var companies = await _sender.Send(query);
            return Ok(companies);
        }
        catch (Exception e)
        {
            _logger.LogError("Internal Server Error");
            return StatusCode(500, "Internal Server Error");
        }
        
    }
}