using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DetailOfActiveGoodsItemsController : DetailOfActiveGoodsItemsControllerBase
{
    public DetailOfActiveGoodsItemsController(IDetailOfActiveGoodsItemsService service)
        : base(service) { }
}
