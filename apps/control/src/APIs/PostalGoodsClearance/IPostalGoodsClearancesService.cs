using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IPostalGoodsClearancesService
{
    /// <summary>
    /// Create one Postal Goods Clearance
    /// </summary>
    public Task<PostalGoodsClearance> CreatePostalGoodsClearance(
        PostalGoodsClearanceCreateInput postalgoodsclearance
    );

    /// <summary>
    /// Delete one Postal Goods Clearance
    /// </summary>
    public Task DeletePostalGoodsClearance(PostalGoodsClearanceWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public Task<List<PostalGoodsClearance>> PostalGoodsClearances(
        PostalGoodsClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Postal Goods Clearance records
    /// </summary>
    public Task<MetadataDto> PostalGoodsClearancesMeta(
        PostalGoodsClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Postal Goods Clearance
    /// </summary>
    public Task<PostalGoodsClearance> PostalGoodsClearance(
        PostalGoodsClearanceWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Postal Goods Clearance
    /// </summary>
    public Task UpdatePostalGoodsClearance(
        PostalGoodsClearanceWhereUniqueInput uniqueId,
        PostalGoodsClearanceUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Postal Goods Clearance Details records to Postal Goods Clearance
    /// </summary>
    public Task ConnectPostalGoodsClearanceDetails(
        PostalGoodsClearanceWhereUniqueInput uniqueId,
        PostalGoodsClearanceDetailWhereUniqueInput[] postalGoodsClearanceDetailsId
    );

    /// <summary>
    /// Disconnect multiple Postal Goods Clearance Details records from Postal Goods Clearance
    /// </summary>
    public Task DisconnectPostalGoodsClearanceDetails(
        PostalGoodsClearanceWhereUniqueInput uniqueId,
        PostalGoodsClearanceDetailWhereUniqueInput[] postalGoodsClearanceDetailsId
    );

    /// <summary>
    /// Find multiple Postal Goods Clearance Details records for Postal Goods Clearance
    /// </summary>
    public Task<List<PostalGoodsClearanceDetail>> FindPostalGoodsClearanceDetails(
        PostalGoodsClearanceWhereUniqueInput uniqueId,
        PostalGoodsClearanceDetailFindManyArgs PostalGoodsClearanceDetailFindManyArgs
    );

    /// <summary>
    /// Update multiple Postal Goods Clearance Details records for Postal Goods Clearance
    /// </summary>
    public Task UpdatePostalGoodsClearanceDetails(
        PostalGoodsClearanceWhereUniqueInput uniqueId,
        PostalGoodsClearanceDetailWhereUniqueInput[] postalGoodsClearanceDetailsId
    );

    /// <summary>
    /// Get a Procedure record for Postal Goods Clearance
    /// </summary>
    public Task<Procedure> GetProcedure(PostalGoodsClearanceWhereUniqueInput uniqueId);
}
