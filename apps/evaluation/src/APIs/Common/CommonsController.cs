using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

[ApiController()]
public class CommonsController : CommonsControllerBase
{
    public CommonsController(ICommonsService service)
        : base(service) { }
}
