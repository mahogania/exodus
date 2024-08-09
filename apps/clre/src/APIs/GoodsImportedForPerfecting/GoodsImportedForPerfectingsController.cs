using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class GoodsImportedForPerfectingsController : GoodsImportedForPerfectingsControllerBase
{
    public GoodsImportedForPerfectingsController(IGoodsImportedForPerfectingsService service)
        : base(service) { }
}
