using Microsoft.AspNetCore.Authorization;

namespace ecommerce.Controllers;

[Authorize(Roles = "Customer")]
public class CustomerRoleController : BaseController
{
    public CustomerRoleController(ILogger<BaseController> logger) : base(logger)
    {
    }
}
