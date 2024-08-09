using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IReceptionsService
{
    /// <summary>
    /// Create one RECEPTION
    /// </summary>
    public Task<Reception> CreateReception(ReceptionCreateInput reception);

    /// <summary>
    /// Delete one RECEPTION
    /// </summary>
    public Task DeleteReception(ReceptionWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many RECEPTIONS
    /// </summary>
    public Task<List<Reception>> Receptions(ReceptionFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about RECEPTION records
    /// </summary>
    public Task<MetadataDto> ReceptionsMeta(ReceptionFindManyArgs findManyArgs);

    /// <summary>
    /// Get one RECEPTION
    /// </summary>
    public Task<Reception> Reception(ReceptionWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one RECEPTION
    /// </summary>
    public Task UpdateReception(ReceptionWhereUniqueInput uniqueId, ReceptionUpdateInput updateDto);
}
