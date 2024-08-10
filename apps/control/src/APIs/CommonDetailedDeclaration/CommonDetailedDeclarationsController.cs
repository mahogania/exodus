using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class CommonDetailedDeclarationsController : CommonDetailedDeclarationsControllerBase
{
    public CommonDetailedDeclarationsController(ICommonDetailedDeclarationsService service)
        : base(service)
    {
    }
}
