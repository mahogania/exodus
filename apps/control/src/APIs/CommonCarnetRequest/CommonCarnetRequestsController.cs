using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonCarnetRequestsController : CommonCarnetRequestsControllerBase
{
    public CommonCarnetRequestsController(ICommonCarnetRequestsService service)
        : base(service) { }
}
