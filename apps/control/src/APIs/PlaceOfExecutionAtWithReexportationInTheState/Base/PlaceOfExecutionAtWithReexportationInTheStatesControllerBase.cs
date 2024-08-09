using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PlaceOfExecutionAtWithReexportationInTheStatesControllerBase : ControllerBase
{
    protected readonly IPlaceOfExecutionAtWithReexportationInTheStatesService _service;

    public PlaceOfExecutionAtWithReexportationInTheStatesControllerBase(
        IPlaceOfExecutionAtWithReexportationInTheStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<PlaceOfExecutionAtWithReexportationInTheState>
    > CreatePlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateCreateInput input
    )
    {
        var placeOfExecutionAtWithReexportationInTheState =
            await _service.CreatePlaceOfExecutionAtWithReexportationInTheState(input);

        return CreatedAtAction(
            nameof(PlaceOfExecutionAtWithReexportationInTheState),
            new { id = placeOfExecutionAtWithReexportationInTheState.Id },
            placeOfExecutionAtWithReexportationInTheState
        );
    }

    /// <summary>
    /// Delete one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePlaceOfExecutionAtWithReexportationInTheState(
        [FromRoute()] PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePlaceOfExecutionAtWithReexportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<PlaceOfExecutionAtWithReexportationInTheState>>
    > PlaceOfExecutionAtWithReexportationInTheStates(
        [FromQuery()] PlaceOfExecutionAtWithReexportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.PlaceOfExecutionAtWithReexportationInTheStates(filter));
    }

    /// <summary>
    /// Meta data about PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PlaceOfExecutionAtWithReexportationInTheStatesMeta(
        [FromQuery()] PlaceOfExecutionAtWithReexportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.PlaceOfExecutionAtWithReexportationInTheStatesMeta(filter));
    }

    /// <summary>
    /// Get one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<PlaceOfExecutionAtWithReexportationInTheState>
    > PlaceOfExecutionAtWithReexportationInTheState(
        [FromRoute()] PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PlaceOfExecutionAtWithReexportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePlaceOfExecutionAtWithReexportationInTheState(
        [FromRoute()] PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        [FromQuery()]
            PlaceOfExecutionAtWithReexportationInTheStateUpdateInput placeOfExecutionAtWithReexportationInTheStateUpdateDto
    )
    {
        try
        {
            await _service.UpdatePlaceOfExecutionAtWithReexportationInTheState(
                uniqueId,
                placeOfExecutionAtWithReexportationInTheStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
