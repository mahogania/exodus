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
}
