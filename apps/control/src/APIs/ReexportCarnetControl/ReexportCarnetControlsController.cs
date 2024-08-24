using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ReexportCarnetControlsController : ReexportCarnetControlsControllerBase
{
    public ReexportCarnetControlsController(IReexportCarnetControlsService service)
        : base(service) { }
}
