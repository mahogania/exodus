using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DetailsOfTheCustomsClearanceOfPostalGoodsItemsController
    : DetailsOfTheCustomsClearanceOfPostalGoodsItemsControllerBase
{
    public DetailsOfTheCustomsClearanceOfPostalGoodsItemsController(
        IDetailsOfTheCustomsClearanceOfPostalGoodsItemsService service
    )
        : base(service) { }
}
