using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class SimplifiedCustomsClearanceOfPostalParcelsItemsController
    : SimplifiedCustomsClearanceOfPostalParcelsItemsControllerBase
{
    public SimplifiedCustomsClearanceOfPostalParcelsItemsController(
        ISimplifiedCustomsClearanceOfPostalParcelsItemsService service
    )
        : base(service) { }
}
