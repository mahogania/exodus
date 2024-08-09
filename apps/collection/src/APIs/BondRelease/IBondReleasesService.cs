using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IBondReleasesService
{
    /// <summary>
    /// Create one BOND RELEASE
    /// </summary>
    public Task<BondRelease> CreateBondRelease(BondReleaseCreateInput bondrelease);

    /// <summary>
    /// Delete one BOND RELEASE
    /// </summary>
    public Task DeleteBondRelease(BondReleaseWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many BOND RELEASES
    /// </summary>
    public Task<List<BondRelease>> BondReleases(BondReleaseFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about BOND RELEASE records
    /// </summary>
    public Task<MetadataDto> BondReleasesMeta(BondReleaseFindManyArgs findManyArgs);

    /// <summary>
    /// Get one BOND RELEASE
    /// </summary>
    public Task<BondRelease> BondRelease(BondReleaseWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one BOND RELEASE
    /// </summary>
    public Task UpdateBondRelease(
        BondReleaseWhereUniqueInput uniqueId,
        BondReleaseUpdateInput updateDto
    );
}
