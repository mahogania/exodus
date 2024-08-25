using Control.Infrastructure;

namespace Control.APIs;

public class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService
    : RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsServiceBase
{
    public RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService(
        ControlDbContext context
    )
        : base(context)
    {
    }
}
