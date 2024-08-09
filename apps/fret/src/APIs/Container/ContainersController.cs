using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[ApiController()]
public class ContainersController : ContainersControllerBase
{
    public ContainersController(IContainersService service)
        : base(service) { }
}
