using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CommonActiveGoodsRequestsController : CommonActiveGoodsRequestsControllerBase
{
    public CommonActiveGoodsRequestsController(ICommonActiveGoodsRequestsService service)
        : base(service) { }
}
