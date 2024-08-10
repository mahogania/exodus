using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class MacSubjectToAuthorizationsController : MacSubjectToAuthorizationsControllerBase
{
    public MacSubjectToAuthorizationsController(IMacSubjectToAuthorizationsService service)
        : base(service)
    {
    }
}
