using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IForeignClientsService
{
    /// <summary>
    /// Create one Foreign Client
    /// </summary>
    public Task<ForeignClient> CreateForeignClient(ForeignClientCreateInput foreignclient);

    /// <summary>
    /// Delete one Foreign Client
    /// </summary>
    public Task DeleteForeignClient(ForeignClientWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Foreign Clients
    /// </summary>
    public Task<List<ForeignClient>> ForeignClients(ForeignClientFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Foreign Client records
    /// </summary>
    public Task<MetadataDto> ForeignClientsMeta(ForeignClientFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Foreign Client
    /// </summary>
    public Task<ForeignClient> ForeignClient(ForeignClientWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Foreign Client
    /// </summary>
    public Task UpdateForeignClient(
        ForeignClientWhereUniqueInput uniqueId,
        ForeignClientUpdateInput updateDto
    );
}
