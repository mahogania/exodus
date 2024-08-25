using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class ExpressCustomsClearanceDetailsItemsController
    : ExpressCustomsClearanceDetailsItemsControllerBase
{
    public ExpressCustomsClearanceDetailsItemsController(
        IExpressCustomsClearanceDetailsItemsService service
    )
        : base(service)
    {
    }
}
