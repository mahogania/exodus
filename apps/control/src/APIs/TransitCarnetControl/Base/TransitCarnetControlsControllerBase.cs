using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TransitCarnetControlsControllerBase : ControllerBase
{
    protected readonly ITransitCarnetControlsService _service;

    public TransitCarnetControlsControllerBase(ITransitCarnetControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Transit Carnet Control
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TransitCarnetControl>> CreateTransitCarnetControl(
        TransitCarnetControlCreateInput input
    )
    {
        var transitCarnetControl = await _service.CreateTransitCarnetControl(input);

        return CreatedAtAction(
            nameof(TransitCarnetControl),
            new { id = transitCarnetControl.Id },
            transitCarnetControl
        );
    }

    /// <summary>
    /// Delete one Transit Carnet Control
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTransitCarnetControl(
        [FromRoute()] TransitCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTransitCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Transit Carnet Controls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TransitCarnetControl>>> TransitCarnetControls(
        [FromQuery()] TransitCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.TransitCarnetControls(filter));
    }

    /// <summary>
    /// Meta data about Transit Carnet Control records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TransitCarnetControlsMeta(
        [FromQuery()] TransitCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.TransitCarnetControlsMeta(filter));
    }

    /// <summary>
    /// Get one Transit Carnet Control
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TransitCarnetControl>> TransitCarnetControl(
        [FromRoute()] TransitCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TransitCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Transit Carnet Control
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTransitCarnetControl(
        [FromRoute()] TransitCarnetControlWhereUniqueInput uniqueId,
        [FromQuery()] TransitCarnetControlUpdateInput transitCarnetControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateTransitCarnetControl(uniqueId, transitCarnetControlUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
