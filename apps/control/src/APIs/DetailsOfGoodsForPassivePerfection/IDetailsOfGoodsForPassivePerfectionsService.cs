using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IDetailsOfGoodsForPassivePerfectionsService
{
    /// <summary>
    /// Create one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public Task<DetailsOfGoodsForPassivePerfection> CreateDetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionCreateInput detailsofgoodsforpassiveperfection
    );

    /// <summary>
    /// Delete one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public Task DeleteDetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DETAILS OF GOODS FOR PASSIVE PERFECTIONS
    /// </summary>
    public Task<List<DetailsOfGoodsForPassivePerfection>> DetailsOfGoodsForPassivePerfections(
        DetailsOfGoodsForPassivePerfectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about DETAILS OF GOODS FOR PASSIVE PERFECTION records
    /// </summary>
    public Task<MetadataDto> DetailsOfGoodsForPassivePerfectionsMeta(
        DetailsOfGoodsForPassivePerfectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public Task<DetailsOfGoodsForPassivePerfection> DetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    public Task UpdateDetailsOfGoodsForPassivePerfection(
        DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId,
        DetailsOfGoodsForPassivePerfectionUpdateInput updateDto
    );
}
