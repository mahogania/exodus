using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ReplenishmentInDutyFreesControllerBase : ControllerBase
{
    protected readonly IReplenishmentInDutyFreesService _service;

    public ReplenishmentInDutyFreesControllerBase(IReplenishmentInDutyFreesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ReplenishmentInDutyFree>> CreateReplenishmentInDutyFree(
        ReplenishmentInDutyFreeCreateInput input
    )
    {
        var replenishmentInDutyFree = await _service.CreateReplenishmentInDutyFree(input);

        return CreatedAtAction(
            nameof(ReplenishmentInDutyFree),
            new { id = replenishmentInDutyFree.Id },
            replenishmentInDutyFree
        );
    }

    /// <summary>
    /// Delete one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReplenishmentInDutyFree(
        [FromRoute()] ReplenishmentInDutyFreeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReplenishmentInDutyFree(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many REPLENISHMENT IN DUTY-FREES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ReplenishmentInDutyFree>>> ReplenishmentInDutyFrees(
        [FromQuery()] ReplenishmentInDutyFreeFindManyArgs filter
    )
    {
        return Ok(await _service.ReplenishmentInDutyFrees(filter));
    }

    /// <summary>
    /// Meta data about REPLENISHMENT IN DUTY-FREE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReplenishmentInDutyFreesMeta(
        [FromQuery()] ReplenishmentInDutyFreeFindManyArgs filter
    )
    {
        return Ok(await _service.ReplenishmentInDutyFreesMeta(filter));
    }

    /// <summary>
    /// Get one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ReplenishmentInDutyFree>> ReplenishmentInDutyFree(
        [FromRoute()] ReplenishmentInDutyFreeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ReplenishmentInDutyFree(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one REPLENISHMENT IN DUTY-FREE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReplenishmentInDutyFree(
        [FromRoute()] ReplenishmentInDutyFreeWhereUniqueInput uniqueId,
        [FromQuery()] ReplenishmentInDutyFreeUpdateInput replenishmentInDutyFreeUpdateDto
    )
    {
        try
        {
            await _service.UpdateReplenishmentInDutyFree(
                uniqueId,
                replenishmentInDutyFreeUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
