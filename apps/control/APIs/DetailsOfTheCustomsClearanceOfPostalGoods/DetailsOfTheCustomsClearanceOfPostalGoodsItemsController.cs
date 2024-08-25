using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class DetailsOfTheCustomsClearanceOfPostalGoodsItemsController
    : DetailsOfTheCustomsClearanceOfPostalGoodsItemsControllerBase
{
    public DetailsOfTheCustomsClearanceOfPostalGoodsItemsController(
        IDetailsOfTheCustomsClearanceOfPostalGoodsItemsService service
    )
        : base(service)
    {
    }
}
