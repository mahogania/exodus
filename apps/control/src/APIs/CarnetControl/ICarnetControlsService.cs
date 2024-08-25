using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICarnetControlsService
{
    /// <summary>
    /// Create one Carnet Control
    /// </summary>
    public Task<CarnetControl> CreateCarnetControl(CarnetControlCreateInput carnetcontrol);

    /// <summary>
    /// Delete one Carnet Control
    /// </summary>
    public Task DeleteCarnetControl(CarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Carnet Controls
    /// </summary>
    public Task<List<CarnetControl>> CarnetControls(CarnetControlFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Carnet Control records
    /// </summary>
    public Task<MetadataDto> CarnetControlsMeta(CarnetControlFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Carnet Control
    /// </summary>
    public Task<CarnetControl> CarnetControl(CarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Carnet Control
    /// </summary>
    public Task UpdateCarnetControl(
        CarnetControlWhereUniqueInput uniqueId,
        CarnetControlUpdateInput updateDto
    );

    /// <summary>
    /// Get a Common Carnet Request record for CarnetControl
    /// </summary>
    public Task<CommonCarnetRequest> GetCommonCarnetRequest(CarnetControlWhereUniqueInput uniqueId);
}
