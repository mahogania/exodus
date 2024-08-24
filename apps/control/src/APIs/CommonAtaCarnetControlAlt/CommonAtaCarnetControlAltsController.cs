using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonAtaCarnetControlAltsController : CommonAtaCarnetControlAltsControllerBase
{
    public CommonAtaCarnetControlAltsController(ICommonAtaCarnetControlAltsService service)
        : base(service) { }
}
