using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonActiveGoodsRequestsService
{
    /// <summary>
    /// Create one Common Active Goods Request
    /// </summary>
    public Task<CommonActiveGoodsRequest> CreateCommonActiveGoodsRequest(
        CommonActiveGoodsRequestCreateInput commonactivegoodsrequest
    );

    /// <summary>
    /// Delete one Common Active Goods Request
    /// </summary>
    public Task DeleteCommonActiveGoodsRequest(CommonActiveGoodsRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COMMON ACTIVE PERFECTIONING GOODS REQUESTS
    /// </summary>
    public Task<List<CommonActiveGoodsRequest>> CommonActiveGoodsRequests(
        CommonActiveGoodsRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Active Goods Request records
    /// </summary>
    public Task<MetadataDto> CommonActiveGoodsRequestsMeta(
        CommonActiveGoodsRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Common Active Goods Request
    /// </summary>
    public Task<CommonActiveGoodsRequest> CommonActiveGoodsRequest(
        CommonActiveGoodsRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Active Goods Request
    /// </summary>
    public Task UpdateCommonActiveGoodsRequest(
        CommonActiveGoodsRequestWhereUniqueInput uniqueId,
        CommonActiveGoodsRequestUpdateInput updateDto
    );
}
