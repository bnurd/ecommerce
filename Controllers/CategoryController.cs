using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers;

public class CategoryController : ManagerRoleController
{
    public CategoryController(ILogger<BaseController> logger) : base(logger)
    {
    }

    [HttpGet(Name = "list"), AllowAnonymous]
    public IEnumerable<Card> GetList()
    {
        return new List<Card> { };
    }

    [HttpPost]
    public IActionResult Add(Category category)
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(int categoryId)
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Put(Category category)
    {
        return Ok();
    }
}
