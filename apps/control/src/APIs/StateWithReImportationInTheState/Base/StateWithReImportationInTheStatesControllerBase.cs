using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class StateWithReImportationInTheStatesControllerBase : ControllerBase
{
    protected readonly IStateWithReImportationInTheStatesService _service;

    public StateWithReImportationInTheStatesControllerBase(
        IStateWithReImportationInTheStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one State With ReImportation In The State
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<StateWithReImportationInTheState>
    > CreateStateWithReImportationInTheState(StateWithReImportationInTheStateCreateInput input)
    {
        var stateWithReImportationInTheState =
            await _service.CreateStateWithReImportationInTheState(input);

        return CreatedAtAction(
            nameof(StateWithReImportationInTheState),
            new { id = stateWithReImportationInTheState.Id },
            stateWithReImportationInTheState
        );
    }

    /// <summary>
    /// Delete one State With ReImportation In The State
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteStateWithReImportationInTheState(
        [FromRoute()] StateWithReImportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteStateWithReImportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many STATE WITH RE-IMPORTATION IN THE STATES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<StateWithReImportationInTheState>>
    > StateWithReImportationInTheStates(
        [FromQuery()] StateWithReImportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.StateWithReImportationInTheStates(filter));
    }

    /// <summary>
    /// Meta data about State With ReImportation In The State records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> StateWithReImportationInTheStatesMeta(
        [FromQuery()] StateWithReImportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.StateWithReImportationInTheStatesMeta(filter));
    }

    /// <summary>
    /// Get one State With ReImportation In The State
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<StateWithReImportationInTheState>
    > StateWithReImportationInTheState(
        [FromRoute()] StateWithReImportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.StateWithReImportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one State With ReImportation In The State
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateStateWithReImportationInTheState(
        [FromRoute()] StateWithReImportationInTheStateWhereUniqueInput uniqueId,
        [FromQuery()]
            StateWithReImportationInTheStateUpdateInput stateWithReImportationInTheStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateStateWithReImportationInTheState(
                uniqueId,
                stateWithReImportationInTheStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
