using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDirectImportationExportationsService
{
    /// <summary>
    /// Create one Direct Importation/Exportation
    /// </summary>
    public Task<DirectImportationExportation> CreateDirectImportationExportation(
        DirectImportationExportationCreateInput directimportationexportation
    );

    /// <summary>
    /// Delete one Direct Importation/Exportation
    /// </summary>
    public Task DeleteDirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DIRECT IMPORTATION/EXPORTATIONS
    /// </summary>
    public Task<List<DirectImportationExportation>> DirectImportationExportations(
        DirectImportationExportationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Direct Importation/Exportation records
    /// </summary>
    public Task<MetadataDto> DirectImportationExportationsMeta(
        DirectImportationExportationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Direct Importation/Exportation
    /// </summary>
    public Task<DirectImportationExportation> DirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Direct Importation/Exportation
    /// </summary>
    public Task UpdateDirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId,
        DirectImportationExportationUpdateInput updateDto
    );
}
