using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class InfosGoodsToBeReprovisionedsController : InfosGoodsToBeReprovisionedsControllerBase
{
    public InfosGoodsToBeReprovisionedsController(IInfosGoodsToBeReprovisionedsService service)
        : base(service) { }
}
