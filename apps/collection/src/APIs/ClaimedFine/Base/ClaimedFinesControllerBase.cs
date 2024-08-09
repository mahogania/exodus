using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ClaimedFinesControllerBase : ControllerBase
{
    protected readonly IClaimedFinesService _service;

    public ClaimedFinesControllerBase(IClaimedFinesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one CLAIMED FINE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ClaimedFine>> CreateClaimedFine(ClaimedFineCreateInput input)
    {
        var claimedFine = await _service.CreateClaimedFine(input);

        return CreatedAtAction(nameof(ClaimedFine), new { id = claimedFine.Id }, claimedFine);
    }

    /// <summary>
    /// Delete one CLAIMED FINE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteClaimedFine(
        [FromRoute()] ClaimedFineWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteClaimedFine(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many CLAIMED FINES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ClaimedFine>>> ClaimedFines(
        [FromQuery()] ClaimedFineFindManyArgs filter
    )
    {
        return Ok(await _service.ClaimedFines(filter));
    }

    /// <summary>
    /// Meta data about CLAIMED FINE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ClaimedFinesMeta(
        [FromQuery()] ClaimedFineFindManyArgs filter
    )
    {
        return Ok(await _service.ClaimedFinesMeta(filter));
    }

    /// <summary>
    /// Get one CLAIMED FINE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ClaimedFine>> ClaimedFine(
        [FromRoute()] ClaimedFineWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ClaimedFine(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one CLAIMED FINE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateClaimedFine(
        [FromRoute()] ClaimedFineWhereUniqueInput uniqueId,
        [FromQuery()] ClaimedFineUpdateInput claimedFineUpdateDto
    )
    {
        try
        {
            await _service.UpdateClaimedFine(uniqueId, claimedFineUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
