using Fret.APIs.Common;
using Fret.APIs.Dtos;

namespace Fret.APIs;

public interface ITrailersService
{
    /// <summary>
    /// Create one Remorque
    /// </summary>
    public Task<Trailer> CreateTrailer(TrailerCreateInput trailer);

    /// <summary>
    /// Delete one Remorque
    /// </summary>
    public Task DeleteTrailer(TrailerWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Trailers
    /// </summary>
    public Task<List<Trailer>> Trailers(TrailerFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Remorque records
    /// </summary>
    public Task<MetadataDto> TrailersMeta(TrailerFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Remorque
    /// </summary>
    public Task<Trailer> Trailer(TrailerWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Remorque
    /// </summary>
    public Task UpdateTrailer(TrailerWhereUniqueInput uniqueId, TrailerUpdateInput updateDto);
}
