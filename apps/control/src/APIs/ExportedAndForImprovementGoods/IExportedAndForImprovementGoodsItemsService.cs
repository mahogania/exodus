using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IExportedAndForImprovementGoodsItemsService
{
    /// <summary>
    ///     Create one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public Task<ExportedAndForImprovementGoods> CreateExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsCreateInput exportedandforimprovementgoods
    );

    /// <summary>
    ///     Delete one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public Task DeleteExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many EXPORTED AND FOR IMPROVEMENT GOODSItems
    /// </summary>
    public Task<List<ExportedAndForImprovementGoods>> ExportedAndForImprovementGoodsItems(
        ExportedAndForImprovementGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about EXPORTED AND FOR IMPROVEMENT GOODS records
    /// </summary>
    public Task<MetadataDto> ExportedAndForImprovementGoodsItemsMeta(
        ExportedAndForImprovementGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public Task<ExportedAndForImprovementGoods> ExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    public Task UpdateExportedAndForImprovementGoods(
        ExportedAndForImprovementGoodsWhereUniqueInput uniqueId,
        ExportedAndForImprovementGoodsUpdateInput updateDto
    );
}
