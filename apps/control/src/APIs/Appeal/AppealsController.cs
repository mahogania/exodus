using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class AppealsController : AppealsControllerBase
{
    public AppealsController(IAppealsService service)
        : base(service) { }
}
