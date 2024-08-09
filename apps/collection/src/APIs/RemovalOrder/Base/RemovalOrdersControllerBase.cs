using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RemovalOrdersControllerBase : ControllerBase
{
    protected readonly IRemovalOrdersService _service;

    public RemovalOrdersControllerBase(IRemovalOrdersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one REMOVAL ORDER
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RemovalOrder>> CreateRemovalOrder(RemovalOrderCreateInput input)
    {
        var removalOrder = await _service.CreateRemovalOrder(input);

        return CreatedAtAction(nameof(RemovalOrder), new { id = removalOrder.Id }, removalOrder);
    }

    /// <summary>
    /// Delete one REMOVAL ORDER
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRemovalOrder(
        [FromRoute()] RemovalOrderWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRemovalOrder(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many REMOVAL ORDERS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RemovalOrder>>> RemovalOrders(
        [FromQuery()] RemovalOrderFindManyArgs filter
    )
    {
        return Ok(await _service.RemovalOrders(filter));
    }

    /// <summary>
    /// Meta data about REMOVAL ORDER records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RemovalOrdersMeta(
        [FromQuery()] RemovalOrderFindManyArgs filter
    )
    {
        return Ok(await _service.RemovalOrdersMeta(filter));
    }

    /// <summary>
    /// Get one REMOVAL ORDER
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RemovalOrder>> RemovalOrder(
        [FromRoute()] RemovalOrderWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RemovalOrder(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one REMOVAL ORDER
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRemovalOrder(
        [FromRoute()] RemovalOrderWhereUniqueInput uniqueId,
        [FromQuery()] RemovalOrderUpdateInput removalOrderUpdateDto
    )
    {
        try
        {
            await _service.UpdateRemovalOrder(uniqueId, removalOrderUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
