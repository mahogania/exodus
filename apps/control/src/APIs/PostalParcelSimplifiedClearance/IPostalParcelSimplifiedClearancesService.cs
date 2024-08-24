using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IPostalParcelSimplifiedClearancesService
{
    /// <summary>
    /// Create one Postal Parcel Simplified Clearance
    /// </summary>
    public Task<PostalParcelSimplifiedClearance> CreatePostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceCreateInput postalparcelsimplifiedclearance
    );

    /// <summary>
    /// Delete one Postal Parcel Simplified Clearance
    /// </summary>
    public Task DeletePostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELSItems
    /// </summary>
    public Task<List<PostalParcelSimplifiedClearance>> PostalParcelSimplifiedClearances(
        PostalParcelSimplifiedClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Postal Parcel Simplified Clearance records
    /// </summary>
    public Task<MetadataDto> PostalParcelSimplifiedClearancesMeta(
        PostalParcelSimplifiedClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Postal Parcel Simplified Clearance
    /// </summary>
    public Task<PostalParcelSimplifiedClearance> PostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Postal Parcel Simplified Clearance
    /// </summary>
    public Task UpdatePostalParcelSimplifiedClearance(
        PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId,
        PostalParcelSimplifiedClearanceUpdateInput updateDto
    );
}
