using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IExpressCustomsClearanceDetailsItemsService
{
    /// <summary>
    /// Create one Express Customs Clearance Detail
    /// </summary>
    public Task<ExpressCustomsClearanceDetails> CreateExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsCreateInput expresscustomsclearancedetails
    );

    /// <summary>
    /// Delete one Express Customs Clearance Detail
    /// </summary>
    public Task DeleteExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Express Customs Clearance Details
    /// </summary>
    public Task<List<ExpressCustomsClearanceDetails>> ExpressCustomsClearanceDetailsItems(
        ExpressCustomsClearanceDetailsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Express Customs Clearance Detail records
    /// </summary>
    public Task<MetadataDto> ExpressCustomsClearanceDetailsItemsMeta(
        ExpressCustomsClearanceDetailsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Express Customs Clearance Detail
    /// </summary>
    public Task<ExpressCustomsClearanceDetails> ExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Express Customs Clearance Detail
    /// </summary>
    public Task UpdateExpressCustomsClearanceDetails(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId,
        ExpressCustomsClearanceDetailsUpdateInput updateDto
    );

    /// <summary>
    /// Get a COMMON EXPRESS CLEARANCE record for EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    public Task<CommonExpressClearance> GetCommonExpressClearance(
        ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    );
}
