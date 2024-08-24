using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IExtendedPeriodCarnetControlsService
{
    /// <summary>
    /// Create one Extended Period Carnet Control
    /// </summary>
    public Task<ExtendedPeriodCarnetControl> CreateExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlCreateInput extendedperiodcarnetcontrol
    );

    /// <summary>
    /// Delete one Extended Period Carnet Control
    /// </summary>
    public Task DeleteExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Extended Period Carnet Controls
    /// </summary>
    public Task<List<ExtendedPeriodCarnetControl>> ExtendedPeriodCarnetControls(
        ExtendedPeriodCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Extended Period Carnet Control records
    /// </summary>
    public Task<MetadataDto> ExtendedPeriodCarnetControlsMeta(
        ExtendedPeriodCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Extended Period Carnet Control
    /// </summary>
    public Task<ExtendedPeriodCarnetControl> ExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Extended Period Carnet Control
    /// </summary>
    public Task UpdateExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetControlUpdateInput updateDto
    );

    /// <summary>
    /// Get a Extended Period Carnet Request record for Extended Period Carnet Control
    /// </summary>
    public Task<ExtendedPeriodCarnetRequest> GetExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    );
}
