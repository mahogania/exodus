using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesController
    : DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesControllerBase
{
    public DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesController(
        IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService service
    )
        : base(service) { }
}
