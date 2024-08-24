using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailOfTheApprovalOfTheRegimeRequestsService
{
    /// <summary>
    /// Create one Detail of the approval of the Regime Request
    /// </summary>
    public Task<DetailOfTheApprovalOfTheRegimeRequest> CreateDetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestCreateInput detailoftheapprovaloftheregimerequest
    );

    /// <summary>
    /// Delete one Detail of the approval of the Regime Request
    /// </summary>
    public Task DeleteDetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Details of the approval of the Regime Request
    /// </summary>
    public Task<List<DetailOfTheApprovalOfTheRegimeRequest>> DetailOfTheApprovalOfTheRegimeRequests(
        DetailOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Detail of the approval of the Regime Request records
    /// </summary>
    public Task<MetadataDto> DetailOfTheApprovalOfTheRegimeRequestsMeta(
        DetailOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Detail of the approval of the Regime Request
    /// </summary>
    public Task<DetailOfTheApprovalOfTheRegimeRequest> DetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Detail of the approval of the Regime Request
    /// </summary>
    public Task UpdateDetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId,
        DetailOfTheApprovalOfTheRegimeRequestUpdateInput updateDto
    );
}
