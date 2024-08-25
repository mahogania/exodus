using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IPostalGoodsClearanceDetailsService
{
    /// <summary>
    /// Create one Postal Goods Clearance Detail
    /// </summary>
    public Task<PostalGoodsClearanceDetail> CreatePostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailCreateInput postalgoodsclearancedetail
    );

    /// <summary>
    /// Delete one Postal Goods Clearance Detail
    /// </summary>
    public Task DeletePostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public Task<List<PostalGoodsClearanceDetail>> PostalGoodsClearanceDetails(
        PostalGoodsClearanceDetailFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Postal Goods Clearance Detail records
    /// </summary>
    public Task<MetadataDto> PostalGoodsClearanceDetailsMeta(
        PostalGoodsClearanceDetailFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Postal Goods Clearance Detail
    /// </summary>
    public Task<PostalGoodsClearanceDetail> PostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Postal Goods Clearance Detail
    /// </summary>
    public Task UpdatePostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId,
        PostalGoodsClearanceDetailUpdateInput updateDto
    );

    /// <summary>
    /// Get a Postal Goods Clearance record for Postal Goods Clearance Detail
    /// </summary>
    public Task<PostalGoodsClearance> GetPostalGoodsClearance(
        PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    );
}
