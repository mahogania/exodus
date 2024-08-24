using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IForeignOperatorRequestsService
{
    /// <summary>
    /// Create one Foreign Operator Request
    /// </summary>
    public Task<ForeignOperatorRequest> CreateForeignOperatorRequest(
        ForeignOperatorRequestCreateInput foreignoperatorrequest
    );

    /// <summary>
    /// Delete one Foreign Operator Request
    /// </summary>
    public Task DeleteForeignOperatorRequest(ForeignOperatorRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many FOREIGN OPERATOR REQUESTS
    /// </summary>
    public Task<List<ForeignOperatorRequest>> ForeignOperatorRequests(
        ForeignOperatorRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Foreign Operator Request records
    /// </summary>
    public Task<MetadataDto> ForeignOperatorRequestsMeta(
        ForeignOperatorRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Foreign Operator Request
    /// </summary>
    public Task<ForeignOperatorRequest> ForeignOperatorRequest(
        ForeignOperatorRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Foreign Operator Request
    /// </summary>
    public Task UpdateForeignOperatorRequest(
        ForeignOperatorRequestWhereUniqueInput uniqueId,
        ForeignOperatorRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Request record for Foreign Operator Request
    /// </summary>
    public Task<Journal> GetRequest(ForeignOperatorRequestWhereUniqueInput uniqueId);
}
