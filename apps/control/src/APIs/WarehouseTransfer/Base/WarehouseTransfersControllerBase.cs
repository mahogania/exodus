using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class WarehouseTransfersControllerBase : ControllerBase
{
    protected readonly IWarehouseTransfersService _service;

    public WarehouseTransfersControllerBase(IWarehouseTransfersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Warehouse Transfer
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<WarehouseTransfer>> CreateWarehouseTransfer(
        WarehouseTransferCreateInput input
    )
    {
        var warehouseTransfer = await _service.CreateWarehouseTransfer(input);

        return CreatedAtAction(
            nameof(WarehouseTransfer),
            new { id = warehouseTransfer.Id },
            warehouseTransfer
        );
    }

    /// <summary>
    /// Delete one Warehouse Transfer
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteWarehouseTransfer(
        [FromRoute()] WarehouseTransferWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteWarehouseTransfer(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many WAREHOUSE TRANSFER (PUBLIC, PRIVATE)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<WarehouseTransfer>>> WarehouseTransfers(
        [FromQuery()] WarehouseTransferFindManyArgs filter
    )
    {
        return Ok(await _service.WarehouseTransfers(filter));
    }

    /// <summary>
    /// Meta data about Warehouse Transfer records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> WarehouseTransfersMeta(
        [FromQuery()] WarehouseTransferFindManyArgs filter
    )
    {
        return Ok(await _service.WarehouseTransfersMeta(filter));
    }

    /// <summary>
    /// Get one Warehouse Transfer
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<WarehouseTransfer>> WarehouseTransfer(
        [FromRoute()] WarehouseTransferWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.WarehouseTransfer(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Warehouse Transfer
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateWarehouseTransfer(
        [FromRoute()] WarehouseTransferWhereUniqueInput uniqueId,
        [FromQuery()] WarehouseTransferUpdateInput warehouseTransferUpdateDto
    )
    {
        try
        {
            await _service.UpdateWarehouseTransfer(uniqueId, warehouseTransferUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
