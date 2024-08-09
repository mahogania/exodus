using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CustomsClearanceOfPostalGoodsItemsController
    : CustomsClearanceOfPostalGoodsItemsControllerBase
{
    public CustomsClearanceOfPostalGoodsItemsController(
        ICustomsClearanceOfPostalGoodsItemsService service
    )
        : base(service) { }
}
