using Microsoft.AspNetCore.Authorization;

namespace ecommerce.Controllers;

[Authorize(Roles = "Manager")]
public class ManagerRoleController : BaseController
{
    public ManagerRoleController(ILogger<BaseController> logger) : base(logger)
    {
    }
}
