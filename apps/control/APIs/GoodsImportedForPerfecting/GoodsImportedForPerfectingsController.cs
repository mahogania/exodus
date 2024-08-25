using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class GoodsImportedForPerfectingsController : GoodsImportedForPerfectingsControllerBase
{
    public GoodsImportedForPerfectingsController(IGoodsImportedForPerfectingsService service)
        : base(service)
    {
    }
}
