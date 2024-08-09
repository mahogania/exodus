using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ISimplifiedCustomsClearanceOfPostalParcelsItemsService
{
    /// <summary>
    /// Create one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public Task<SimplifiedCustomsClearanceOfPostalParcels> CreateSimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsCreateInput simplifiedcustomsclearanceofpostalparcels
    );

    /// <summary>
    /// Delete one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public Task DeleteSimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELSItems
    /// </summary>
    public Task<
        List<SimplifiedCustomsClearanceOfPostalParcels>
    > SimplifiedCustomsClearanceOfPostalParcelsItems(
        SimplifiedCustomsClearanceOfPostalParcelsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS records
    /// </summary>
    public Task<MetadataDto> SimplifiedCustomsClearanceOfPostalParcelsItemsMeta(
        SimplifiedCustomsClearanceOfPostalParcelsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public Task<SimplifiedCustomsClearanceOfPostalParcels> SimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    public Task UpdateSimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId,
        SimplifiedCustomsClearanceOfPostalParcelsUpdateInput updateDto
    );
}
