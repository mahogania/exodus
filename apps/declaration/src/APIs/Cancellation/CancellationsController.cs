using Microsoft.AspNetCore.Mvc;

namespace Statement.APIs;

[ApiController()]
public class CancellationsController : CancellationsControllerBase
{
    public CancellationsController(ICancellationsService service)
        : base(service) { }
}
