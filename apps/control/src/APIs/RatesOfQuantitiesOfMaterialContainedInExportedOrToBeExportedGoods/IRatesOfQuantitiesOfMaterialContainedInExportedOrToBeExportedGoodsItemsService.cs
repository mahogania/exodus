using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService
{
    /// <summary>
    ///     Create one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public Task<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods>
        CreateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsCreateInput
                ratesofquantitiesofmaterialcontainedinexportedortobeexportedgoods
        );

    /// <summary>
    ///     Delete one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public Task DeleteRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODSItems
    /// </summary>
    public Task<
        List<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods>
    > RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS records
    /// </summary>
    public Task<MetadataDto> RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsMeta(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public Task<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods>
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId
        );

    /// <summary>
    ///     Update one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    public Task UpdateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId,
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsUpdateInput updateDto
    );
}
