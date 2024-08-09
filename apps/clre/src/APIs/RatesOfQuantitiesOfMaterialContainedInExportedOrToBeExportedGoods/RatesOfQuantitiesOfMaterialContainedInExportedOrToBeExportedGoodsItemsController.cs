using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsController
    : RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsControllerBase
{
    public RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsController(
        IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService service
    )
        : base(service) { }
}
