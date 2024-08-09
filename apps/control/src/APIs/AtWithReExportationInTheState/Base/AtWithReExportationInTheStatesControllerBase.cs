using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AtWithReExportationInTheStatesControllerBase : ControllerBase
{
    protected readonly IAtWithReExportationInTheStatesService _service;

    public AtWithReExportationInTheStatesControllerBase(
        IAtWithReExportationInTheStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<AtWithReExportationInTheState>
    > CreateAtWithReExportationInTheState(AtWithReExportationInTheStateCreateInput input)
    {
        var atWithReExportationInTheState = await _service.CreateAtWithReExportationInTheState(
            input
        );

        return CreatedAtAction(
            nameof(AtWithReExportationInTheState),
            new { id = atWithReExportationInTheState.Id },
            atWithReExportationInTheState
        );
    }

    /// <summary>
    /// Delete one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAtWithReExportationInTheState(
        [FromRoute()] AtWithReExportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAtWithReExportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many AT WITH RE-EXPORTATION IN THE STATES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<AtWithReExportationInTheState>>
    > AtWithReExportationInTheStates([FromQuery()] AtWithReExportationInTheStateFindManyArgs filter)
    {
        return Ok(await _service.AtWithReExportationInTheStates(filter));
    }

    /// <summary>
    /// Meta data about AT WITH RE-EXPORTATION IN THE STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AtWithReExportationInTheStatesMeta(
        [FromQuery()] AtWithReExportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.AtWithReExportationInTheStatesMeta(filter));
    }

    /// <summary>
    /// Get one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AtWithReExportationInTheState>> AtWithReExportationInTheState(
        [FromRoute()] AtWithReExportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.AtWithReExportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAtWithReExportationInTheState(
        [FromRoute()] AtWithReExportationInTheStateWhereUniqueInput uniqueId,
        [FromQuery()]
            AtWithReExportationInTheStateUpdateInput atWithReExportationInTheStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateAtWithReExportationInTheState(
                uniqueId,
                atWithReExportationInTheStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
