using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IReplenishmentsService
{
    /// <summary>
    /// Create one Replenishment
    /// </summary>
    public Task<Replenishment> CreateReplenishment(ReplenishmentCreateInput replenishment);

    /// <summary>
    /// Delete one Replenishment
    /// </summary>
    public Task DeleteReplenishment(ReplenishmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Replenishments
    /// </summary>
    public Task<List<Replenishment>> Replenishments(ReplenishmentFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Replenishment records
    /// </summary>
    public Task<MetadataDto> ReplenishmentsMeta(ReplenishmentFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Replenishment
    /// </summary>
    public Task<Replenishment> Replenishment(ReplenishmentWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Replenishment
    /// </summary>
    public Task UpdateReplenishment(
        ReplenishmentWhereUniqueInput uniqueId,
        ReplenishmentUpdateInput updateDto
    );
}
