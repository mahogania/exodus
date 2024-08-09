using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ForeignOperatorRequestsController : ForeignOperatorRequestsControllerBase
{
    public ForeignOperatorRequestsController(IForeignOperatorRequestsService service)
        : base(service) { }
}
