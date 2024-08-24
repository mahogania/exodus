using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ReplenishmentsController : ReplenishmentsControllerBase
{
    public ReplenishmentsController(IReplenishmentsService service)
        : base(service) { }
}
