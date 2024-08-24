using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ExtendedPeriodCarnetControlsController : ExtendedPeriodCarnetControlsControllerBase
{
    public ExtendedPeriodCarnetControlsController(IExtendedPeriodCarnetControlsService service)
        : base(service) { }
}
