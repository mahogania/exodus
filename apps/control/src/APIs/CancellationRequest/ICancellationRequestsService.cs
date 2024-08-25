using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICancellationRequestsService
{
    /// <summary>
    /// Create one Cancellation Request
    /// </summary>
    public Task<CancellationRequest> CreateCancellationRequest(
        CancellationRequestCreateInput cancellationrequest
    );

    /// <summary>
    /// Delete one Cancellation Request
    /// </summary>
    public Task DeleteCancellationRequest(CancellationRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Cancellation Requests
    /// </summary>
    public Task<List<CancellationRequest>> CancellationRequests(
        CancellationRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Cancellation Request records
    /// </summary>
    public Task<MetadataDto> CancellationRequestsMeta(CancellationRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Cancellation Request
    /// </summary>
    public Task<CancellationRequest> CancellationRequest(
        CancellationRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Cancellation Request
    /// </summary>
    public Task UpdateCancellationRequest(
        CancellationRequestWhereUniqueInput uniqueId,
        CancellationRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Request record for Cancellation Request
    /// </summary>
    public Task<Procedure> GetRequest(CancellationRequestWhereUniqueInput uniqueId);
}
