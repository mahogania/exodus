using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IExpressCustomsClearanceDetailsItemsService
{
    /// <summary>
    /// Create one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public Task<ExpressCustomsClearanceDetails> CreateExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsCreateInput expresscustomsclearancedetails
    );

    /// <summary>
    /// Delete one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public Task DeleteExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many EXPRESS CUSTOMS CLEARANCE DETAILSItems
    /// </summary>
    public Task<List<ExpressCustomsClearanceDetails>> ExpressCustomsClearanceDetailsItems(
        ExpressCustomsClearanceDetailsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about EXPRESS CUSTOMS CLEARANCE DETAILS records
    /// </summary>
    public Task<MetadataDto> ExpressCustomsClearanceDetailsItemsMeta(
        ExpressCustomsClearanceDetailsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public Task<ExpressCustomsClearanceDetails> ExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public Task UpdateExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId,
        ExpressCustomsClearanceDetailsUpdateInput updateDto
    );
}
