using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class TransitCarnetRequestsController : TransitCarnetRequestsControllerBase
{
    public TransitCarnetRequestsController(ITransitCarnetRequestsService service)
        : base(service) { }
}
