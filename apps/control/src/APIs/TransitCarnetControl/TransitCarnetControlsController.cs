using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class TransitCarnetControlsController : TransitCarnetControlsControllerBase
{
    public TransitCarnetControlsController(ITransitCarnetControlsService service)
        : base(service) { }
}
