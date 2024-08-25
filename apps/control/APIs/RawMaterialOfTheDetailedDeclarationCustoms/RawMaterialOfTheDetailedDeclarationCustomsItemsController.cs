using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class RawMaterialOfTheDetailedDeclarationCustomsItemsController
    : RawMaterialOfTheDetailedDeclarationCustomsItemsControllerBase
{
    public RawMaterialOfTheDetailedDeclarationCustomsItemsController(
        IRawMaterialOfTheDetailedDeclarationCustomsItemsService service
    )
        : base(service)
    {
    }
}
