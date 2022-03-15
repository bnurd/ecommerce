using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers;

public class OrderController : CustomerRoleController
{
    public OrderController(ILogger<BaseController> logger) : base(logger)
    {
    }

    [HttpGet(Name = "list")]
    public IEnumerable<Order> GetList()
    {
        return new List<Order> { };
    }

    [HttpGet]
    public Order Get(int Id)
    {
        return new Order { };
    }

    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpDelete]
    public IEnumerable<Order> Delete(int orderId)
    {
        // business code : if order state == waiting ? ok : bad req
        return new List<Order> { };
    }

    [HttpPut]
    public IEnumerable<Order> Put(int orderId , Order order)
    {
        // business code : if order state == waiting ? ok : bad req
        return new List<Order> { };
    }

}
