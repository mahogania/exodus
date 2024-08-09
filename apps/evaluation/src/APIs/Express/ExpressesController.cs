using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

[ApiController()]
public class ExpressesController : ExpressesControllerBase
{
    public ExpressesController(IExpressesService service)
        : base(service) { }
}
