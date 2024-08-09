using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IStateOfGoodsForPassivePerfectionCommonsService
{
    /// <summary>
    /// Create one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public Task<StateOfGoodsForPassivePerfectionCommon> CreateStateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonCreateInput stateofgoodsforpassiveperfectioncommon
    );

    /// <summary>
    /// Delete one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public Task DeleteStateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many STATE OF GOODS FOR PASSIVE PERFECTION COMMONS
    /// </summary>
    public Task<
        List<StateOfGoodsForPassivePerfectionCommon>
    > StateOfGoodsForPassivePerfectionCommons(
        StateOfGoodsForPassivePerfectionCommonFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about STATE OF GOODS FOR PASSIVE PERFECTION COMMON records
    /// </summary>
    public Task<MetadataDto> StateOfGoodsForPassivePerfectionCommonsMeta(
        StateOfGoodsForPassivePerfectionCommonFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public Task<StateOfGoodsForPassivePerfectionCommon> StateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one STATE OF GOODS FOR PASSIVE PERFECTION COMMON
    /// </summary>
    public Task UpdateStateOfGoodsForPassivePerfectionCommon(
        StateOfGoodsForPassivePerfectionCommonWhereUniqueInput uniqueId,
        StateOfGoodsForPassivePerfectionCommonUpdateInput updateDto
    );
}
