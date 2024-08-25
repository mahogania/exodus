using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class AppealsController : AppealsControllerBase
{
    public AppealsController(IAppealsService service)
        : base(service) { }
}
