using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class FineRequestsController : FineRequestsControllerBase
{
    public FineRequestsController(IFineRequestsService service)
        : base(service) { }
}
