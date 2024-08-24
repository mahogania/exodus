using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IImportedGoodsInformationsService
{
    /// <summary>
    /// Create one Imported Goods Information
    /// </summary>
    public Task<ImportedGoodsInformation> CreateImportedGoodsInformation(
        ImportedGoodsInformationCreateInput importedgoodsinformation
    );

    /// <summary>
    /// Delete one Imported Goods Information
    /// </summary>
    public Task DeleteImportedGoodsInformation(ImportedGoodsInformationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many IMPORTED GOODS INFORMATIONS
    /// </summary>
    public Task<List<ImportedGoodsInformation>> ImportedGoodsInformations(
        ImportedGoodsInformationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Imported Goods Information records
    /// </summary>
    public Task<MetadataDto> ImportedGoodsInformationsMeta(
        ImportedGoodsInformationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Imported Goods Information
    /// </summary>
    public Task<ImportedGoodsInformation> ImportedGoodsInformation(
        ImportedGoodsInformationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Imported Goods Information
    /// </summary>
    public Task UpdateImportedGoodsInformation(
        ImportedGoodsInformationWhereUniqueInput uniqueId,
        ImportedGoodsInformationUpdateInput updateDto
    );
}
