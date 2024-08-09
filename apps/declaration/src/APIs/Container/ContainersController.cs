using Microsoft.AspNetCore.Mvc;

namespace Statement.APIs;

[ApiController()]
public class ContainersController : ContainersControllerBase
{
    public ContainersController(IContainersService service)
        : base(service) { }
}
