using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class PlaceOfExecutionAndWithReImportationInStatesControllerBase : ControllerBase
{
    protected readonly IPlaceOfExecutionAndWithReImportationInStatesService _service;

    public PlaceOfExecutionAndWithReImportationInStatesControllerBase(
        IPlaceOfExecutionAndWithReImportationInStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<PlaceOfExecutionAndWithReImportationInState>
    > CreatePlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateCreateInput input
    )
    {
        var placeOfExecutionAndWithReImportationInState =
            await _service.CreatePlaceOfExecutionAndWithReImportationInState(input);

        return CreatedAtAction(
            nameof(PlaceOfExecutionAndWithReImportationInState),
            new { id = placeOfExecutionAndWithReImportationInState.Id },
            placeOfExecutionAndWithReImportationInState
        );
    }

    /// <summary>
    ///     Delete one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePlaceOfExecutionAndWithReImportationInState(
        [FromRoute] PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePlaceOfExecutionAndWithReImportationInState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<PlaceOfExecutionAndWithReImportationInState>>
    > PlaceOfExecutionAndWithReImportationInStates(
        [FromQuery] PlaceOfExecutionAndWithReImportationInStateFindManyArgs filter
    )
    {
        return Ok(await _service.PlaceOfExecutionAndWithReImportationInStates(filter));
    }

    /// <summary>
    ///     Meta data about PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PlaceOfExecutionAndWithReImportationInStatesMeta(
        [FromQuery] PlaceOfExecutionAndWithReImportationInStateFindManyArgs filter
    )
    {
        return Ok(await _service.PlaceOfExecutionAndWithReImportationInStatesMeta(filter));
    }

    /// <summary>
    ///     Get one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<PlaceOfExecutionAndWithReImportationInState>
    > PlaceOfExecutionAndWithReImportationInState(
        [FromRoute] PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PlaceOfExecutionAndWithReImportationInState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePlaceOfExecutionAndWithReImportationInState(
        [FromRoute] PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId,
        [FromQuery]
        PlaceOfExecutionAndWithReImportationInStateUpdateInput placeOfExecutionAndWithReImportationInStateUpdateDto
    )
    {
        try
        {
            await _service.UpdatePlaceOfExecutionAndWithReImportationInState(
                uniqueId,
                placeOfExecutionAndWithReImportationInStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
