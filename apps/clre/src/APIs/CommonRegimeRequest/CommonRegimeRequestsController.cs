using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CommonRegimeRequestsController : CommonRegimeRequestsControllerBase
{
    public CommonRegimeRequestsController(ICommonRegimeRequestsService service)
        : base(service) { }
}
