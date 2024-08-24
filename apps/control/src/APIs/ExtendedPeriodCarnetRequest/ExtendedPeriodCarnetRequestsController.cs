using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ExtendedPeriodCarnetRequestsController : ExtendedPeriodCarnetRequestsControllerBase
{
    public ExtendedPeriodCarnetRequestsController(IExtendedPeriodCarnetRequestsService service)
        : base(service) { }
}
