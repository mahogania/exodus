using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class StateForPerfectionsControllerBase : ControllerBase
{
    protected readonly IStateForPerfectionsService _service;

    public StateForPerfectionsControllerBase(IStateForPerfectionsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one STATE FOR PERFECTION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<StateForPerfection>> CreateStateForPerfection(
        StateForPerfectionCreateInput input
    )
    {
        var stateForPerfection = await _service.CreateStateForPerfection(input);

        return CreatedAtAction(
            nameof(StateForPerfection),
            new { id = stateForPerfection.Id },
            stateForPerfection
        );
    }

    /// <summary>
    /// Delete one STATE FOR PERFECTION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteStateForPerfection(
        [FromRoute()] StateForPerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteStateForPerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many STATE FOR PERFECTIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<StateForPerfection>>> StateForPerfections(
        [FromQuery()] StateForPerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.StateForPerfections(filter));
    }

    /// <summary>
    /// Meta data about STATE FOR PERFECTION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> StateForPerfectionsMeta(
        [FromQuery()] StateForPerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.StateForPerfectionsMeta(filter));
    }

    /// <summary>
    /// Get one STATE FOR PERFECTION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<StateForPerfection>> StateForPerfection(
        [FromRoute()] StateForPerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.StateForPerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one STATE FOR PERFECTION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateStateForPerfection(
        [FromRoute()] StateForPerfectionWhereUniqueInput uniqueId,
        [FromQuery()] StateForPerfectionUpdateInput stateForPerfectionUpdateDto
    )
    {
        try
        {
            await _service.UpdateStateForPerfection(uniqueId, stateForPerfectionUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
