using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

[ApiController()]
public class RequestsController : RequestsControllerBase
{
    public RequestsController(IRequestsService service)
        : base(service) { }
}
