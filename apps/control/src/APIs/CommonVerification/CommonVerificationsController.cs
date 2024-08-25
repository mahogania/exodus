using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonVerificationsController : CommonVerificationsControllerBase
{
    public CommonVerificationsController(ICommonVerificationsService service)
        : base(service) { }
}
