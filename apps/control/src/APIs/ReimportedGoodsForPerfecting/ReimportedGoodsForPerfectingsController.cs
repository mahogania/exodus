using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ReimportedGoodsForPerfectingsController : ReimportedGoodsForPerfectingsControllerBase
{
    public ReimportedGoodsForPerfectingsController(IReimportedGoodsForPerfectingsService service)
        : base(service) { }
}
