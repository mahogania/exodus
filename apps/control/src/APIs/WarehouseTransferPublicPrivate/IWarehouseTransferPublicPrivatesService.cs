using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IWarehouseTransferPublicPrivatesService
{
    /// <summary>
    /// Create one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public Task<WarehouseTransferPublicPrivate> CreateWarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateCreateInput warehousetransferpublicprivate
    );

    /// <summary>
    /// Delete one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public Task DeleteWarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many WAREHOUSE TRANSFER (PUBLIC, PRIVATE)s
    /// </summary>
    public Task<List<WarehouseTransferPublicPrivate>> WarehouseTransferPublicPrivates(
        WarehouseTransferPublicPrivateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about WAREHOUSE TRANSFER (PUBLIC, PRIVATE) records
    /// </summary>
    public Task<MetadataDto> WarehouseTransferPublicPrivatesMeta(
        WarehouseTransferPublicPrivateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public Task<WarehouseTransferPublicPrivate> WarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    public Task UpdateWarehouseTransferPublicPrivate(
        WarehouseTransferPublicPrivateWhereUniqueInput uniqueId,
        WarehouseTransferPublicPrivateUpdateInput updateDto
    );
}
