using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ForeignOperatorRequestsController : ForeignOperatorRequestsControllerBase
{
    public ForeignOperatorRequestsController(IForeignOperatorRequestsService service)
        : base(service) { }
}
