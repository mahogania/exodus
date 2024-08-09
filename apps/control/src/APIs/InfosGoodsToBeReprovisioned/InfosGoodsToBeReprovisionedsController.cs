using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class InfosGoodsToBeReprovisionedsController : InfosGoodsToBeReprovisionedsControllerBase
{
    public InfosGoodsToBeReprovisionedsController(IInfosGoodsToBeReprovisionedsService service)
        : base(service) { }
}
