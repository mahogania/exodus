using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IDetailsOfAtGoodsForActivePerfectingsService
{
    /// <summary>
    /// Create one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public Task<DetailsOfAtGoodsForActivePerfecting> CreateDetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingCreateInput detailsofatgoodsforactiveperfecting
    );

    /// <summary>
    /// Delete one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public Task DeleteDetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DETAILS OF AT GOODS FOR ACTIVE PERFECTINGS
    /// </summary>
    public Task<List<DetailsOfAtGoodsForActivePerfecting>> DetailsOfAtGoodsForActivePerfectings(
        DetailsOfAtGoodsForActivePerfectingFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about DETAILS OF AT GOODS FOR ACTIVE PERFECTING records
    /// </summary>
    public Task<MetadataDto> DetailsOfAtGoodsForActivePerfectingsMeta(
        DetailsOfAtGoodsForActivePerfectingFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public Task<DetailsOfAtGoodsForActivePerfecting> DetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    public Task UpdateDetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId,
        DetailsOfAtGoodsForActivePerfectingUpdateInput updateDto
    );
}
