using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CancellationRequestsController : CancellationRequestsControllerBase
{
    public CancellationRequestsController(ICancellationRequestsService service)
        : base(service) { }
}
