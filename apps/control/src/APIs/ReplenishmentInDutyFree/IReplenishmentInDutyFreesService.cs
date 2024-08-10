using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IReplenishmentInDutyFreesService
{
    /// <summary>
    ///     Create one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public Task<ReplenishmentInDutyFree> CreateReplenishmentInDutyFree(
        ReplenishmentInDutyFreeCreateInput replenishmentindutyfree
    );

    /// <summary>
    ///     Delete one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public Task DeleteReplenishmentInDutyFree(ReplenishmentInDutyFreeWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many REPLENISHMENT IN DUTY-FREES
    /// </summary>
    public Task<List<ReplenishmentInDutyFree>> ReplenishmentInDutyFrees(
        ReplenishmentInDutyFreeFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about REPLENISHMENT IN DUTY-FREE records
    /// </summary>
    public Task<MetadataDto> ReplenishmentInDutyFreesMeta(
        ReplenishmentInDutyFreeFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public Task<ReplenishmentInDutyFree> ReplenishmentInDutyFree(
        ReplenishmentInDutyFreeWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    public Task UpdateReplenishmentInDutyFree(
        ReplenishmentInDutyFreeWhereUniqueInput uniqueId,
        ReplenishmentInDutyFreeUpdateInput updateDto
    );
}
