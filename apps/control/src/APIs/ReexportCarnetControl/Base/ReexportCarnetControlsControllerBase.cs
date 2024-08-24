using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ReexportCarnetControlsControllerBase : ControllerBase
{
    protected readonly IReexportCarnetControlsService _service;

    public ReexportCarnetControlsControllerBase(IReexportCarnetControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Reexport Carnet Control
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ReexportCarnetControl>> CreateReexportCarnetControl(
        ReexportCarnetControlCreateInput input
    )
    {
        var reexportCarnetControl = await _service.CreateReexportCarnetControl(input);

        return CreatedAtAction(
            nameof(ReexportCarnetControl),
            new { id = reexportCarnetControl.Id },
            reexportCarnetControl
        );
    }

    /// <summary>
    /// Delete one Reexport Carnet Control
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReexportCarnetControl(
        [FromRoute()] ReexportCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReexportCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Reexport Carnet Controls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ReexportCarnetControl>>> ReexportCarnetControls(
        [FromQuery()] ReexportCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ReexportCarnetControls(filter));
    }

    /// <summary>
    /// Meta data about Reexport Carnet Control records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReexportCarnetControlsMeta(
        [FromQuery()] ReexportCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ReexportCarnetControlsMeta(filter));
    }

    /// <summary>
    /// Get one Reexport Carnet Control
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ReexportCarnetControl>> ReexportCarnetControl(
        [FromRoute()] ReexportCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ReexportCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Reexport Carnet Control
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReexportCarnetControl(
        [FromRoute()] ReexportCarnetControlWhereUniqueInput uniqueId,
        [FromQuery()] ReexportCarnetControlUpdateInput reexportCarnetControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateReexportCarnetControl(uniqueId, reexportCarnetControlUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Reexport Carnet Request record for Reexport Carnet Control
    /// </summary>
    [HttpGet("{Id}/reexportCarnetRequests")]
    public async Task<ActionResult<List<ReexportCarnetRequest>>> GetReexportCarnetRequests(
        [FromRoute()] ReexportCarnetControlWhereUniqueInput uniqueId
    )
    {
        var reexportCarnetRequest = await _service.GetReexportCarnetRequests(uniqueId);
        return Ok(reexportCarnetRequest);
    }
}
