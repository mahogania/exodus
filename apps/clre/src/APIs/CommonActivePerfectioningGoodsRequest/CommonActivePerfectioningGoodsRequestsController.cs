using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class CommonActivePerfectioningGoodsRequestsController
    : CommonActivePerfectioningGoodsRequestsControllerBase
{
    public CommonActivePerfectioningGoodsRequestsController(
        ICommonActivePerfectioningGoodsRequestsService service
    )
        : base(service) { }
}
