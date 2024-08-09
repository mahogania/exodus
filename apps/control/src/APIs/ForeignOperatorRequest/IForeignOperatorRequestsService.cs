using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IForeignOperatorRequestsService
{
    /// <summary>
    /// Create one FOREIGN OPERATOR REQUEST
    /// </summary>
    public Task<ForeignOperatorRequest> CreateForeignOperatorRequest(
        ForeignOperatorRequestCreateInput foreignoperatorrequest
    );

    /// <summary>
    /// Delete one FOREIGN OPERATOR REQUEST
    /// </summary>
    public Task DeleteForeignOperatorRequest(ForeignOperatorRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many FOREIGN OPERATOR REQUESTS
    /// </summary>
    public Task<List<ForeignOperatorRequest>> ForeignOperatorRequests(
        ForeignOperatorRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about FOREIGN OPERATOR REQUEST records
    /// </summary>
    public Task<MetadataDto> ForeignOperatorRequestsMeta(
        ForeignOperatorRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one FOREIGN OPERATOR REQUEST
    /// </summary>
    public Task<ForeignOperatorRequest> ForeignOperatorRequest(
        ForeignOperatorRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one FOREIGN OPERATOR REQUEST
    /// </summary>
    public Task UpdateForeignOperatorRequest(
        ForeignOperatorRequestWhereUniqueInput uniqueId,
        ForeignOperatorRequestUpdateInput updateDto
    );
}
