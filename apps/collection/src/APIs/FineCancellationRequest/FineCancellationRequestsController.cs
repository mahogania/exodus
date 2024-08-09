using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class FineCancellationRequestsController : FineCancellationRequestsControllerBase
{
    public FineCancellationRequestsController(IFineCancellationRequestsService service)
        : base(service) { }
}
