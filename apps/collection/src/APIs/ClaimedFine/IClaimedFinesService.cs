using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IClaimedFinesService
{
    /// <summary>
    /// Create one CLAIMED FINE
    /// </summary>
    public Task<ClaimedFine> CreateClaimedFine(ClaimedFineCreateInput claimedfine);

    /// <summary>
    /// Delete one CLAIMED FINE
    /// </summary>
    public Task DeleteClaimedFine(ClaimedFineWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CLAIMED FINES
    /// </summary>
    public Task<List<ClaimedFine>> ClaimedFines(ClaimedFineFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about CLAIMED FINE records
    /// </summary>
    public Task<MetadataDto> ClaimedFinesMeta(ClaimedFineFindManyArgs findManyArgs);

    /// <summary>
    /// Get one CLAIMED FINE
    /// </summary>
    public Task<ClaimedFine> ClaimedFine(ClaimedFineWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one CLAIMED FINE
    /// </summary>
    public Task UpdateClaimedFine(
        ClaimedFineWhereUniqueInput uniqueId,
        ClaimedFineUpdateInput updateDto
    );
}
