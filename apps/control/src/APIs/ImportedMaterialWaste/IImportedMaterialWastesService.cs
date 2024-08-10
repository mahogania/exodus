using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IImportedMaterialWastesService
{
    /// <summary>
    ///     Create one IMPORTED MATERIAL WASTE
    /// </summary>
    public Task<ImportedMaterialWaste> CreateImportedMaterialWaste(
        ImportedMaterialWasteCreateInput importedmaterialwaste
    );

    /// <summary>
    ///     Delete one IMPORTED MATERIAL WASTE
    /// </summary>
    public Task DeleteImportedMaterialWaste(ImportedMaterialWasteWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many IMPORTED MATERIAL WASTES
    /// </summary>
    public Task<List<ImportedMaterialWaste>> ImportedMaterialWastes(
        ImportedMaterialWasteFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about IMPORTED MATERIAL WASTE records
    /// </summary>
    public Task<MetadataDto> ImportedMaterialWastesMeta(
        ImportedMaterialWasteFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one IMPORTED MATERIAL WASTE
    /// </summary>
    public Task<ImportedMaterialWaste> ImportedMaterialWaste(
        ImportedMaterialWasteWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one IMPORTED MATERIAL WASTE
    /// </summary>
    public Task UpdateImportedMaterialWaste(
        ImportedMaterialWasteWhereUniqueInput uniqueId,
        ImportedMaterialWasteUpdateInput updateDto
    );
}
