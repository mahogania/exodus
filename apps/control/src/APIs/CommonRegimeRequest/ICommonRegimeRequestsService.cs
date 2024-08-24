using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonRegimeRequestsService
{
    /// <summary>
    /// Create one Common Regime Request
    /// </summary>
    public Task<CommonRegimeRequest> CreateCommonRegimeRequest(
        CommonRegimeRequestCreateInput commonregimerequest
    );

    /// <summary>
    /// Delete one Common Regime Request
    /// </summary>
    public Task DeleteCommonRegimeRequest(CommonRegimeRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COMMON REGIME REQUESTS
    /// </summary>
    public Task<List<CommonRegimeRequest>> CommonRegimeRequests(
        CommonRegimeRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Regime Request records
    /// </summary>
    public Task<MetadataDto> CommonRegimeRequestsMeta(CommonRegimeRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Common Regime Request
    /// </summary>
    public Task<CommonRegimeRequest> CommonRegimeRequest(
        CommonRegimeRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Regime Request
    /// </summary>
    public Task UpdateCommonRegimeRequest(
        CommonRegimeRequestWhereUniqueInput uniqueId,
        CommonRegimeRequestUpdateInput updateDto
    );
}
