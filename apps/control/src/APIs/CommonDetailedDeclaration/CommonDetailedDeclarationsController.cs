using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CommonDetailedDeclarationsController : CommonDetailedDeclarationsControllerBase
{
    public CommonDetailedDeclarationsController(ICommonDetailedDeclarationsService service)
        : base(service) { }
}
