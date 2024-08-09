using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[ApiController()]
public class CommonsController : CommonsControllerBase
{
    public CommonsController(ICommonsService service)
        : base(service) { }
}
