using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonAtaCarnetControlsController : CommonAtaCarnetControlsControllerBase
{
    public CommonAtaCarnetControlsController(ICommonAtaCarnetControlsService service)
        : base(service) { }
}
