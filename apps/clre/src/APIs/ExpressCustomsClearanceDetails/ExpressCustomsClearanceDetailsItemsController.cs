using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ExpressCustomsClearanceDetailsItemsController
    : ExpressCustomsClearanceDetailsItemsControllerBase
{
    public ExpressCustomsClearanceDetailsItemsController(
        IExpressCustomsClearanceDetailsItemsService service
    )
        : base(service) { }
}
