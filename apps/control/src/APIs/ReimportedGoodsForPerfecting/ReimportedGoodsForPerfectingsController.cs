using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ReimportedGoodsForPerfectingsController : ReimportedGoodsForPerfectingsControllerBase
{
    public ReimportedGoodsForPerfectingsController(IReimportedGoodsForPerfectingsService service)
        : base(service) { }
}
