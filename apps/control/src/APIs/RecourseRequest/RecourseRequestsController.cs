using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class RecourseRequestsController : RecourseRequestsControllerBase
{
    public RecourseRequestsController(IRecourseRequestsService service)
        : base(service) { }
}
