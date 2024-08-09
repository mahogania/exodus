using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class GoodsMacSuiteAtAndWithReExportationInStatesControllerBase : ControllerBase
{
    protected readonly IGoodsMacSuiteAtAndWithReExportationInStatesService _service;

    public GoodsMacSuiteAtAndWithReExportationInStatesControllerBase(
        IGoodsMacSuiteAtAndWithReExportationInStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<GoodsMacSuiteAtAndWithReExportationInState>
    > CreateGoodsMacSuiteAtAndWithReExportationInState(
        GoodsMacSuiteAtAndWithReExportationInStateCreateInput input
    )
    {
        var goodsMacSuiteAtAndWithReExportationInState =
            await _service.CreateGoodsMacSuiteAtAndWithReExportationInState(input);

        return CreatedAtAction(
            nameof(GoodsMacSuiteAtAndWithReExportationInState),
            new { id = goodsMacSuiteAtAndWithReExportationInState.Id },
            goodsMacSuiteAtAndWithReExportationInState
        );
    }

    /// <summary>
    /// Delete one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteGoodsMacSuiteAtAndWithReExportationInState(
        [FromRoute()] GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteGoodsMacSuiteAtAndWithReExportationInState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GoodsMacSuiteAtAndWithReExportationInState>>
    > GoodsMacSuiteAtAndWithReExportationInStates(
        [FromQuery()] GoodsMacSuiteAtAndWithReExportationInStateFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsMacSuiteAtAndWithReExportationInStates(filter));
    }

    /// <summary>
    /// Meta data about GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> GoodsMacSuiteAtAndWithReExportationInStatesMeta(
        [FromQuery()] GoodsMacSuiteAtAndWithReExportationInStateFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsMacSuiteAtAndWithReExportationInStatesMeta(filter));
    }

    /// <summary>
    /// Get one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<GoodsMacSuiteAtAndWithReExportationInState>
    > GoodsMacSuiteAtAndWithReExportationInState(
        [FromRoute()] GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.GoodsMacSuiteAtAndWithReExportationInState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one GOODS MAC SUITE AT AND WITH RE-EXPORTATION IN STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGoodsMacSuiteAtAndWithReExportationInState(
        [FromRoute()] GoodsMacSuiteAtAndWithReExportationInStateWhereUniqueInput uniqueId,
        [FromQuery()]
            GoodsMacSuiteAtAndWithReExportationInStateUpdateInput goodsMacSuiteAtAndWithReExportationInStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateGoodsMacSuiteAtAndWithReExportationInState(
                uniqueId,
                goodsMacSuiteAtAndWithReExportationInStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
