using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICarnetControlsService
{
    /// <summary>
    /// Create one CarnetControl
    /// </summary>
    public Task<CarnetControl> CreateCarnetControl(CarnetControlCreateInput carnetcontrol);

    /// <summary>
    /// Delete one CarnetControl
    /// </summary>
    public Task DeleteCarnetControl(CarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CarnetControls
    /// </summary>
    public Task<List<CarnetControl>> CarnetControls(CarnetControlFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about CarnetControl records
    /// </summary>
    public Task<MetadataDto> CarnetControlsMeta(CarnetControlFindManyArgs findManyArgs);

    /// <summary>
    /// Get one CarnetControl
    /// </summary>
    public Task<CarnetControl> CarnetControl(CarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one CarnetControl
    /// </summary>
    public Task UpdateCarnetControl(
        CarnetControlWhereUniqueInput uniqueId,
        CarnetControlUpdateInput updateDto
    );
}
