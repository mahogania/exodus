using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ReplenishmentsControllerBase : ControllerBase
{
    protected readonly IReplenishmentsService _service;

    public ReplenishmentsControllerBase(IReplenishmentsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Replenishment
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Replenishment>> CreateReplenishment(
        ReplenishmentCreateInput input
    )
    {
        var replenishment = await _service.CreateReplenishment(input);

        return CreatedAtAction(nameof(Replenishment), new { id = replenishment.Id }, replenishment);
    }

    /// <summary>
    /// Delete one Replenishment
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReplenishment(
        [FromRoute()] ReplenishmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReplenishment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Replenishments
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Replenishment>>> Replenishments(
        [FromQuery()] ReplenishmentFindManyArgs filter
    )
    {
        return Ok(await _service.Replenishments(filter));
    }

    /// <summary>
    /// Meta data about Replenishment records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReplenishmentsMeta(
        [FromQuery()] ReplenishmentFindManyArgs filter
    )
    {
        return Ok(await _service.ReplenishmentsMeta(filter));
    }

    /// <summary>
    /// Get one Replenishment
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Replenishment>> Replenishment(
        [FromRoute()] ReplenishmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Replenishment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Replenishment
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReplenishment(
        [FromRoute()] ReplenishmentWhereUniqueInput uniqueId,
        [FromQuery()] ReplenishmentUpdateInput replenishmentUpdateDto
    )
    {
        try
        {
            await _service.UpdateReplenishment(uniqueId, replenishmentUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
