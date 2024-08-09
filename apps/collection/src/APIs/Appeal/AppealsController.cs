using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class AppealsController : AppealsControllerBase
{
    public AppealsController(IAppealsService service)
        : base(service) { }
}
