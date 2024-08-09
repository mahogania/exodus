using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class WarehouseTransferPublicPrivatesControllerBase : ControllerBase
{
    protected readonly IWarehouseTransferPublicPrivatesService _service;

    public WarehouseTransferPublicPrivatesControllerBase(
        IWarehouseTransferPublicPrivatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<WarehouseTransferPublicPrivate>
    > CreateWarehouseTransferPublicPrivate(WarehouseTransferPublicPrivateCreateInput input)
    {
        var warehouseTransferPublicPrivate = await _service.CreateWarehouseTransferPublicPrivate(
            input
        );

        return CreatedAtAction(
            nameof(WarehouseTransferPublicPrivate),
            new { id = warehouseTransferPublicPrivate.Id },
            warehouseTransferPublicPrivate
        );
    }

    /// <summary>
    /// Delete one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteWarehouseTransferPublicPrivate(
        [FromRoute()] WarehouseTransferPublicPrivateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteWarehouseTransferPublicPrivate(uniqueId);
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
    public async Task<
        ActionResult<List<WarehouseTransferPublicPrivate>>
    > WarehouseTransferPublicPrivates(
        [FromQuery()] WarehouseTransferPublicPrivateFindManyArgs filter
    )
    {
        return Ok(await _service.WarehouseTransferPublicPrivates(filter));
    }

    /// <summary>
    /// Meta data about WAREHOUSE TRANSFER (PUBLIC, PRIVATE) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> WarehouseTransferPublicPrivatesMeta(
        [FromQuery()] WarehouseTransferPublicPrivateFindManyArgs filter
    )
    {
        return Ok(await _service.WarehouseTransferPublicPrivatesMeta(filter));
    }

    /// <summary>
    /// Get one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<WarehouseTransferPublicPrivate>> WarehouseTransferPublicPrivate(
        [FromRoute()] WarehouseTransferPublicPrivateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.WarehouseTransferPublicPrivate(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one WAREHOUSE TRANSFER (PUBLIC, PRIVATE)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateWarehouseTransferPublicPrivate(
        [FromRoute()] WarehouseTransferPublicPrivateWhereUniqueInput uniqueId,
        [FromQuery()]
            WarehouseTransferPublicPrivateUpdateInput warehouseTransferPublicPrivateUpdateDto
    )
    {
        try
        {
            await _service.UpdateWarehouseTransferPublicPrivate(
                uniqueId,
                warehouseTransferPublicPrivateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
