using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonCarnetRequestsService
{
    /// <summary>
    /// Create one Common Carnet Request
    /// </summary>
    public Task<CommonCarnetRequest> CreateCommonCarnetRequest(
        CommonCarnetRequestCreateInput commoncarnetrequest
    );

    /// <summary>
    /// Delete one Common Carnet Request
    /// </summary>
    public Task DeleteCommonCarnetRequest(CommonCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Common Carnet Requests
    /// </summary>
    public Task<List<CommonCarnetRequest>> CommonCarnetRequests(
        CommonCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Carnet Request records
    /// </summary>
    public Task<MetadataDto> CommonCarnetRequestsMeta(CommonCarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Common Carnet Request
    /// </summary>
    public Task<CommonCarnetRequest> CommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Carnet Request
    /// </summary>
    public Task UpdateCommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CommonCarnetRequestUpdateInput updateDto
    );
}
