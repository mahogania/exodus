using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsController
    : RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsControllerBase
{
    public RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsController(
        IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService service
    )
        : base(service)
    {
    }
}
