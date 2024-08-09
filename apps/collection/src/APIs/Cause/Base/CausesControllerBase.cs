using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CausesControllerBase : ControllerBase
{
    protected readonly ICausesService _service;

    public CausesControllerBase(ICausesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one CAUSE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Cause>> CreateCause(CauseCreateInput input)
    {
        var cause = await _service.CreateCause(input);

        return CreatedAtAction(nameof(Cause), new { id = cause.Id }, cause);
    }

    /// <summary>
    /// Delete one CAUSE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCause([FromRoute()] CauseWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteCause(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many CAUSES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Cause>>> Causes([FromQuery()] CauseFindManyArgs filter)
    {
        return Ok(await _service.Causes(filter));
    }

    /// <summary>
    /// Meta data about CAUSE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CausesMeta([FromQuery()] CauseFindManyArgs filter)
    {
        return Ok(await _service.CausesMeta(filter));
    }

    /// <summary>
    /// Get one CAUSE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Cause>> Cause([FromRoute()] CauseWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Cause(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one CAUSE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCause(
        [FromRoute()] CauseWhereUniqueInput uniqueId,
        [FromQuery()] CauseUpdateInput causeUpdateDto
    )
    {
        try
        {
            await _service.UpdateCause(uniqueId, causeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
