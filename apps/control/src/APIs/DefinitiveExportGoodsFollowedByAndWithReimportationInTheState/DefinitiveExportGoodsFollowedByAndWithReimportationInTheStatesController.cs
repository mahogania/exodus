using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesController
    : DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesControllerBase
{
    public DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesController(
        IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService service
    )
        : base(service) { }
}
