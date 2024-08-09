using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class MacSuiteAtWithReexportationInTheStatesControllerBase : ControllerBase
{
    protected readonly IMacSuiteAtWithReexportationInTheStatesService _service;

    public MacSuiteAtWithReexportationInTheStatesControllerBase(
        IMacSuiteAtWithReexportationInTheStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<MacSuiteAtWithReexportationInTheState>
    > CreateMacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateCreateInput input
    )
    {
        var macSuiteAtWithReexportationInTheState =
            await _service.CreateMacSuiteAtWithReexportationInTheState(input);

        return CreatedAtAction(
            nameof(MacSuiteAtWithReexportationInTheState),
            new { id = macSuiteAtWithReexportationInTheState.Id },
            macSuiteAtWithReexportationInTheState
        );
    }

    /// <summary>
    /// Delete one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteMacSuiteAtWithReexportationInTheState(
        [FromRoute()] MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteMacSuiteAtWithReexportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many MAC SUITE AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<MacSuiteAtWithReexportationInTheState>>
    > MacSuiteAtWithReexportationInTheStates(
        [FromQuery()] MacSuiteAtWithReexportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.MacSuiteAtWithReexportationInTheStates(filter));
    }

    /// <summary>
    /// Meta data about MAC SUITE AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> MacSuiteAtWithReexportationInTheStatesMeta(
        [FromQuery()] MacSuiteAtWithReexportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.MacSuiteAtWithReexportationInTheStatesMeta(filter));
    }

    /// <summary>
    /// Get one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<MacSuiteAtWithReexportationInTheState>
    > MacSuiteAtWithReexportationInTheState(
        [FromRoute()] MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.MacSuiteAtWithReexportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateMacSuiteAtWithReexportationInTheState(
        [FromRoute()] MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        [FromQuery()]
            MacSuiteAtWithReexportationInTheStateUpdateInput macSuiteAtWithReexportationInTheStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateMacSuiteAtWithReexportationInTheState(
                uniqueId,
                macSuiteAtWithReexportationInTheStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
