using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class TpdControlsController : TpdControlsControllerBase
{
    public TpdControlsController(ITpdControlsService service)
        : base(service) { }
}
