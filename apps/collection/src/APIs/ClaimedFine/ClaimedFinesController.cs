using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class ClaimedFinesController : ClaimedFinesControllerBase
{
    public ClaimedFinesController(IClaimedFinesService service)
        : base(service) { }
}
