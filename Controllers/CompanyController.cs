using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers;

public class CompanyController : ManagerRoleController
{
    public CompanyController(ILogger<BaseController> logger) : base(logger)
    {
    }

    [HttpGet]
    public Company Get()
    {
        return new Company { };
    }

    [HttpPost]
    public IActionResult Add()
    {
        // if there is a company return bad request
        return Ok();
    }

    [HttpPost]
    public IActionResult Put(Company company)
    {
        return Ok();
    }
}
