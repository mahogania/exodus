using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonRegimeRequestsController : CommonRegimeRequestsControllerBase
{
    public CommonRegimeRequestsController(ICommonRegimeRequestsService service)
        : base(service) { }
}
