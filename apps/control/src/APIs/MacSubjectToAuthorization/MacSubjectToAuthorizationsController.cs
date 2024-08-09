using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class MacSubjectToAuthorizationsController : MacSubjectToAuthorizationsControllerBase
{
    public MacSubjectToAuthorizationsController(IMacSubjectToAuthorizationsService service)
        : base(service) { }
}
