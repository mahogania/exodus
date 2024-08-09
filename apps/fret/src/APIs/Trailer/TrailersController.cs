using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[ApiController()]
public class TrailersController : TrailersControllerBase
{
    public TrailersController(ITrailersService service)
        : base(service) { }
}
