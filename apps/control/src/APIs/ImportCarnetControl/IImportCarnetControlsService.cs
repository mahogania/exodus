using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IImportCarnetControlsService
{
    /// <summary>
    /// Create one Import Carnet Control
    /// </summary>
    public Task<ImportCarnetControl> CreateImportCarnetControl(
        ImportCarnetControlCreateInput importcarnetcontrol
    );

    /// <summary>
    /// Delete one Import Carnet Control
    /// </summary>
    public Task DeleteImportCarnetControl(ImportCarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Import Carnet Controls
    /// </summary>
    public Task<List<ImportCarnetControl>> ImportCarnetControls(
        ImportCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Import Carnet Control records
    /// </summary>
    public Task<MetadataDto> ImportCarnetControlsMeta(ImportCarnetControlFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Import Carnet Control
    /// </summary>
    public Task<ImportCarnetControl> ImportCarnetControl(
        ImportCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Import Carnet Control
    /// </summary>
    public Task UpdateImportCarnetControl(
        ImportCarnetControlWhereUniqueInput uniqueId,
        ImportCarnetControlUpdateInput updateDto
    );
}
