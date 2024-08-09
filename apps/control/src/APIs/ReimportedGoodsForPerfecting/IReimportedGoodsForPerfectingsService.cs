using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IReimportedGoodsForPerfectingsService
{
    /// <summary>
    /// Create one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public Task<ReimportedGoodsForPerfecting> CreateReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingCreateInput reimportedgoodsforperfecting
    );

    /// <summary>
    /// Delete one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public Task DeleteReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many REIMPORTED GOODS FOR PERFECTINGS
    /// </summary>
    public Task<List<ReimportedGoodsForPerfecting>> ReimportedGoodsForPerfectings(
        ReimportedGoodsForPerfectingFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about REIMPORTED GOODS FOR PERFECTING records
    /// </summary>
    public Task<MetadataDto> ReimportedGoodsForPerfectingsMeta(
        ReimportedGoodsForPerfectingFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public Task<ReimportedGoodsForPerfecting> ReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    public Task UpdateReimportedGoodsForPerfecting(
        ReimportedGoodsForPerfectingWhereUniqueInput uniqueId,
        ReimportedGoodsForPerfectingUpdateInput updateDto
    );
}
