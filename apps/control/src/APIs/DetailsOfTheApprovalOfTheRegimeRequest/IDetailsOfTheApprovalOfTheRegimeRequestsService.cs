using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailsOfTheApprovalOfTheRegimeRequestsService
{
    /// <summary>
    ///     Create one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public Task<DetailsOfTheApprovalOfTheRegimeRequest> CreateDetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestCreateInput detailsoftheapprovaloftheregimerequest
    );

    /// <summary>
    ///     Delete one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public Task DeleteDetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many details of the approval of the regime requests
    /// </summary>
    public Task<
        List<DetailsOfTheApprovalOfTheRegimeRequest>
    > DetailsOfTheApprovalOfTheRegimeRequests(
        DetailsOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about DETAIL OF THE APPROVAL OF THE REGIME REQUEST records
    /// </summary>
    public Task<MetadataDto> DetailsOfTheApprovalOfTheRegimeRequestsMeta(
        DetailsOfTheApprovalOfTheRegimeRequestFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public Task<DetailsOfTheApprovalOfTheRegimeRequest> DetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    public Task UpdateDetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId,
        DetailsOfTheApprovalOfTheRegimeRequestUpdateInput updateDto
    );
}
