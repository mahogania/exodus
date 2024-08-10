using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class CommonActivePerfectioningGoodsRequestsController
    : CommonActivePerfectioningGoodsRequestsControllerBase
{
    public CommonActivePerfectioningGoodsRequestsController(
        ICommonActivePerfectioningGoodsRequestsService service
    )
        : base(service)
    {
    }
}
