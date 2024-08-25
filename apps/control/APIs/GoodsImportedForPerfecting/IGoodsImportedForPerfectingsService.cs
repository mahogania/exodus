using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IGoodsImportedForPerfectingsService
{
    /// <summary>
    ///     Create one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public Task<GoodsImportedForPerfecting> CreateGoodsImportedForPerfecting(
        GoodsImportedForPerfectingCreateInput goodsimportedforperfecting
    );

    /// <summary>
    ///     Delete one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public Task DeleteGoodsImportedForPerfecting(
        GoodsImportedForPerfectingWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many GOODS IMPORTED FOR PERFECTINGS
    /// </summary>
    public Task<List<GoodsImportedForPerfecting>> GoodsImportedForPerfectings(
        GoodsImportedForPerfectingFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about GOODS IMPORTED FOR PERFECTING records
    /// </summary>
    public Task<MetadataDto> GoodsImportedForPerfectingsMeta(
        GoodsImportedForPerfectingFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public Task<GoodsImportedForPerfecting> GoodsImportedForPerfecting(
        GoodsImportedForPerfectingWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    public Task UpdateGoodsImportedForPerfecting(
        GoodsImportedForPerfectingWhereUniqueInput uniqueId,
        GoodsImportedForPerfectingUpdateInput updateDto
    );
}
