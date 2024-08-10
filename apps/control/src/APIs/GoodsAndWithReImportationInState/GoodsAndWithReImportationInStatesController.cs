using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class GoodsAndWithReImportationInStatesController
    : GoodsAndWithReImportationInStatesControllerBase
{
    public GoodsAndWithReImportationInStatesController(
        IGoodsAndWithReImportationInStatesService service
    )
        : base(service)
    {
    }
}
