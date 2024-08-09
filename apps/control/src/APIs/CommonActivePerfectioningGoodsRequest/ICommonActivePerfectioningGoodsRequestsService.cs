using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonActivePerfectioningGoodsRequestsService
{
    /// <summary>
    /// Create one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public Task<CommonActivePerfectioningGoodsRequest> CreateCommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestCreateInput commonactiveperfectioninggoodsrequest
    );

    /// <summary>
    /// Delete one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public Task DeleteCommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many COMMON ACTIVE PERFECTIONING GOODS REQUESTS
    /// </summary>
    public Task<List<CommonActivePerfectioningGoodsRequest>> CommonActivePerfectioningGoodsRequests(
        CommonActivePerfectioningGoodsRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about COMMON ACTIVE PERFECTIONING GOODS REQUEST records
    /// </summary>
    public Task<MetadataDto> CommonActivePerfectioningGoodsRequestsMeta(
        CommonActivePerfectioningGoodsRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public Task<CommonActivePerfectioningGoodsRequest> CommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    public Task UpdateCommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId,
        CommonActivePerfectioningGoodsRequestUpdateInput updateDto
    );
}
