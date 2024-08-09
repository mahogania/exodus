using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class DistributionsController : DistributionsControllerBase
{
    public DistributionsController(IDistributionsService service)
        : base(service) { }
}
