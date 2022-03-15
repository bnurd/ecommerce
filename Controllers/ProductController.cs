using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers;

public class ProductController : ManagerRoleController
{
    public ProductController(ILogger<BaseController> logger) : base(logger)
    {
    }

    [HttpGet(Name = "list"), AllowAnonymous]
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

    [HttpPut]
    public IActionResult Put(Product product)
    {
        return Ok();
    }
}
