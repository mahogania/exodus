using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class GoodsAndWithReImportationInStatesController
    : GoodsAndWithReImportationInStatesControllerBase
{
    public GoodsAndWithReImportationInStatesController(
        IGoodsAndWithReImportationInStatesService service
    )
        : base(service) { }
}
