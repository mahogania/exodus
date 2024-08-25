using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IExportedOrToBeExportedGoodsInformationsService
{
    /// <summary>
    ///     Create one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public Task<ExportedOrToBeExportedGoodsInformation> CreateExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationCreateInput exportedortobeexportedgoodsinformation
    );

    /// <summary>
    ///     Delete one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public Task DeleteExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many EXPORTED OR TO BE EXPORTED GOODS INFORMATIONS
    /// </summary>
    public Task<
        List<ExportedOrToBeExportedGoodsInformation>
    > ExportedOrToBeExportedGoodsInformations(
        ExportedOrToBeExportedGoodsInformationFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about EXPORTED OR TO BE EXPORTED GOODS INFORMATION records
    /// </summary>
    public Task<MetadataDto> ExportedOrToBeExportedGoodsInformationsMeta(
        ExportedOrToBeExportedGoodsInformationFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public Task<ExportedOrToBeExportedGoodsInformation> ExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    public Task UpdateExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId,
        ExportedOrToBeExportedGoodsInformationUpdateInput updateDto
    );
}
