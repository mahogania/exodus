using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IInformationOfGoodsTransferredInWarehousePublicPrivatesService
{
    /// <summary>
    ///     Create one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public Task<InformationOfGoodsTransferredInWarehousePublicPrivate>
        CreateInformationOfGoodsTransferredInWarehousePublicPrivate(
            InformationOfGoodsTransferredInWarehousePublicPrivateCreateInput
                informationofgoodstransferredinwarehousepublicprivate
        );

    /// <summary>
    ///     Delete one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public Task DeleteInformationOfGoodsTransferredInWarehousePublicPrivate(
        InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)s
    /// </summary>
    public Task<
        List<InformationOfGoodsTransferredInWarehousePublicPrivate>
    > InformationOfGoodsTransferredInWarehousePublicPrivates(
        InformationOfGoodsTransferredInWarehousePublicPrivateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE) records
    /// </summary>
    public Task<MetadataDto> InformationOfGoodsTransferredInWarehousePublicPrivatesMeta(
        InformationOfGoodsTransferredInWarehousePublicPrivateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public Task<InformationOfGoodsTransferredInWarehousePublicPrivate>
        InformationOfGoodsTransferredInWarehousePublicPrivate(
            InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId
        );

    /// <summary>
    ///     Update one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    public Task UpdateInformationOfGoodsTransferredInWarehousePublicPrivate(
        InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId,
        InformationOfGoodsTransferredInWarehousePublicPrivateUpdateInput updateDto
    );
}
