using Clre.Infrastructure;

namespace Clre.APIs;

public class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService
    : RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsServiceBase
{
    public RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService(
        ClreDbContext context
    )
        : base(context) { }
}
