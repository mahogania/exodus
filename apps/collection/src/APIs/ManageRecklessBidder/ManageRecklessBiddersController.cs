using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class ManageRecklessBiddersController : ManageRecklessBiddersControllerBase
{
    public ManageRecklessBiddersController(IManageRecklessBiddersService service)
        : base(service)
    {
    }
}
