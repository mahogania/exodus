using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDirectImportationExportationsService
{
    /// <summary>
    ///     Create one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public Task<DirectImportationExportation> CreateDirectImportationExportation(
        DirectImportationExportationCreateInput directimportationexportation
    );

    /// <summary>
    ///     Delete one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public Task DeleteDirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many DIRECT IMPORTATION/EXPORTATIONS
    /// </summary>
    public Task<List<DirectImportationExportation>> DirectImportationExportations(
        DirectImportationExportationFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about DIRECT IMPORTATION/EXPORTATION records
    /// </summary>
    public Task<MetadataDto> DirectImportationExportationsMeta(
        DirectImportationExportationFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public Task<DirectImportationExportation> DirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    public Task UpdateDirectImportationExportation(
        DirectImportationExportationWhereUniqueInput uniqueId,
        DirectImportationExportationUpdateInput updateDto
    );
}
