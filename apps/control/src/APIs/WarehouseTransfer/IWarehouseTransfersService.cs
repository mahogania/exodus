using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IWarehouseTransfersService
{
    /// <summary>
    /// Create one Warehouse Transfer
    /// </summary>
    public Task<WarehouseTransfer> CreateWarehouseTransfer(
        WarehouseTransferCreateInput warehousetransfer
    );

    /// <summary>
    /// Delete one Warehouse Transfer
    /// </summary>
    public Task DeleteWarehouseTransfer(WarehouseTransferWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many WAREHOUSE TRANSFER (PUBLIC, PRIVATE)s
    /// </summary>
    public Task<List<WarehouseTransfer>> WarehouseTransfers(
        WarehouseTransferFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Warehouse Transfer records
    /// </summary>
    public Task<MetadataDto> WarehouseTransfersMeta(WarehouseTransferFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Warehouse Transfer
    /// </summary>
    public Task<WarehouseTransfer> WarehouseTransfer(WarehouseTransferWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Warehouse Transfer
    /// </summary>
    public Task UpdateWarehouseTransfer(
        WarehouseTransferWhereUniqueInput uniqueId,
        WarehouseTransferUpdateInput updateDto
    );
}
