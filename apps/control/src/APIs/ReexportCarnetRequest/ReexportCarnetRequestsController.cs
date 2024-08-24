using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ReexportCarnetRequestsController : ReexportCarnetRequestsControllerBase
{
    public ReexportCarnetRequestsController(IReexportCarnetRequestsService service)
        : base(service) { }
}
