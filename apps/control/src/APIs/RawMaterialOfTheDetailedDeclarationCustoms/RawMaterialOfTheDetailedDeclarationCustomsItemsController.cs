using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class RawMaterialOfTheDetailedDeclarationCustomsItemsController
    : RawMaterialOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public RawMaterialOfTheDetailedDeclarationCustomsItemsController(
        IRawMaterialOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service) { }
}
