using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[ApiController()]
public class TrainsController : TrainsControllerBase
{
    public TrainsController(ITrainsService service)
        : base(service) { }
}
