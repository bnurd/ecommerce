using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers;

[ApiController]
[Route("[controller]")]
public class CardController : CustomerRoleController
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public CardController(ILogger<BaseController> logger) : base(logger)
    {
    }

    [HttpGet(Name = "list")]
    public IEnumerable<Card> GetList()
    {
        return new List<Card> { };
    }

    [HttpPost]
    public IActionResult Add()
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok();
    }
}
