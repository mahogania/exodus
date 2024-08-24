using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ExtendedPeriodCarnetControlsControllerBase : ControllerBase
{
    protected readonly IExtendedPeriodCarnetControlsService _service;

    public ExtendedPeriodCarnetControlsControllerBase(IExtendedPeriodCarnetControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Extended Period Carnet Control
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExtendedPeriodCarnetControl>> CreateExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetControlCreateInput input
    )
    {
        var extendedPeriodCarnetControl = await _service.CreateExtendedPeriodCarnetControl(input);

        return CreatedAtAction(
            nameof(ExtendedPeriodCarnetControl),
            new { id = extendedPeriodCarnetControl.Id },
            extendedPeriodCarnetControl
        );
    }

    /// <summary>
    /// Delete one Extended Period Carnet Control
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExtendedPeriodCarnetControl(
        [FromRoute()] ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteExtendedPeriodCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Extended Period Carnet Controls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ExtendedPeriodCarnetControl>>> ExtendedPeriodCarnetControls(
        [FromQuery()] ExtendedPeriodCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ExtendedPeriodCarnetControls(filter));
    }

    /// <summary>
    /// Meta data about Extended Period Carnet Control records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExtendedPeriodCarnetControlsMeta(
        [FromQuery()] ExtendedPeriodCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ExtendedPeriodCarnetControlsMeta(filter));
    }

    /// <summary>
    /// Get one Extended Period Carnet Control
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExtendedPeriodCarnetControl>> ExtendedPeriodCarnetControl(
        [FromRoute()] ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ExtendedPeriodCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Extended Period Carnet Control
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExtendedPeriodCarnetControl(
        [FromRoute()] ExtendedPeriodCarnetControlWhereUniqueInput uniqueId,
        [FromQuery()] ExtendedPeriodCarnetControlUpdateInput extendedPeriodCarnetControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateExtendedPeriodCarnetControl(
                uniqueId,
                extendedPeriodCarnetControlUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
