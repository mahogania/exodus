using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CustomsClearanceOfPostalGoodsItemsController
    : CustomsClearanceOfPostalGoodsItemsControllerBase
{
    public CustomsClearanceOfPostalGoodsItemsController(
        ICustomsClearanceOfPostalGoodsItemsService service
    )
        : base(service) { }
}
