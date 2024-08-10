using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class SimplifiedCustomsClearanceOfPostalParcelsItemsController
    : SimplifiedCustomsClearanceOfPostalParcelsItemsControllerBase
{
    public SimplifiedCustomsClearanceOfPostalParcelsItemsController(
        ISimplifiedCustomsClearanceOfPostalParcelsItemsService service
    )
        : base(service)
    {
    }
}
