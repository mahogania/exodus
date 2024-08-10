using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IRefundRequestsService
{
    /// <summary>
    ///     Create one REFUND REQUEST
    /// </summary>
    public Task<RefundRequest> CreateRefundRequest(RefundRequestCreateInput refundrequest);

    /// <summary>
    ///     Delete one REFUND REQUEST
    /// </summary>
    public Task DeleteRefundRequest(RefundRequestWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many REFUND REQUESTS
    /// </summary>
    public Task<List<RefundRequest>> RefundRequests(RefundRequestFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about REFUND REQUEST records
    /// </summary>
    public Task<MetadataDto> RefundRequestsMeta(RefundRequestFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one REFUND REQUEST
    /// </summary>
    public Task<RefundRequest> RefundRequest(RefundRequestWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one REFUND REQUEST
    /// </summary>
    public Task UpdateRefundRequest(
        RefundRequestWhereUniqueInput uniqueId,
        RefundRequestUpdateInput updateDto
    );
}
