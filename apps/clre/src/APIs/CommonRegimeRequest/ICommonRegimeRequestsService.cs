using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface ICommonRegimeRequestsService
{
    /// <summary>
    /// Create one COMMON REGIME REQUEST
    /// </summary>
    public Task<CommonRegimeRequest> CreateCommonRegimeRequest(
        CommonRegimeRequestCreateInput commonregimerequest
    );

    /// <summary>
    /// Delete one COMMON REGIME REQUEST
    /// </summary>
    public Task DeleteCommonRegimeRequest(CommonRegimeRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COMMON REGIME REQUESTS
    /// </summary>
    public Task<List<CommonRegimeRequest>> CommonRegimeRequests(
        CommonRegimeRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about COMMON REGIME REQUEST records
    /// </summary>
    public Task<MetadataDto> CommonRegimeRequestsMeta(CommonRegimeRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one COMMON REGIME REQUEST
    /// </summary>
    public Task<CommonRegimeRequest> CommonRegimeRequest(
        CommonRegimeRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one COMMON REGIME REQUEST
    /// </summary>
    public Task UpdateCommonRegimeRequest(
        CommonRegimeRequestWhereUniqueInput uniqueId,
        CommonRegimeRequestUpdateInput updateDto
    );
}
