using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IFineCancellationRequestsService
{
    /// <summary>
    ///     Create one FINE CANCELLATION REQUEST
    /// </summary>
    public Task<FineCancellationRequest> CreateFineCancellationRequest(
        FineCancellationRequestCreateInput finecancellationrequest
    );

    /// <summary>
    ///     Delete one FINE CANCELLATION REQUEST
    /// </summary>
    public Task DeleteFineCancellationRequest(FineCancellationRequestWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many FINE CANCELLATION REQUESTS
    /// </summary>
    public Task<List<FineCancellationRequest>> FineCancellationRequests(
        FineCancellationRequestFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about FINE CANCELLATION REQUEST records
    /// </summary>
    public Task<MetadataDto> FineCancellationRequestsMeta(
        FineCancellationRequestFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one FINE CANCELLATION REQUEST
    /// </summary>
    public Task<FineCancellationRequest> FineCancellationRequest(
        FineCancellationRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one FINE CANCELLATION REQUEST
    /// </summary>
    public Task UpdateFineCancellationRequest(
        FineCancellationRequestWhereUniqueInput uniqueId,
        FineCancellationRequestUpdateInput updateDto
    );
}
