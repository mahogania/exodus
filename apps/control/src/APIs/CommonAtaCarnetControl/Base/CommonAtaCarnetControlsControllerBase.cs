using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonAtaCarnetControlsControllerBase : ControllerBase
{
    protected readonly ICommonAtaCarnetControlsService _service;

    public CommonAtaCarnetControlsControllerBase(ICommonAtaCarnetControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common ATA Carnet Control
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonAtaCarnetControl>> CreateCommonAtaCarnetControl(
        CommonAtaCarnetControlCreateInput input
    )
    {
        var commonAtaCarnetControl = await _service.CreateCommonAtaCarnetControl(input);

        return CreatedAtAction(
            nameof(CommonAtaCarnetControl),
            new { id = commonAtaCarnetControl.Id },
            commonAtaCarnetControl
        );
    }

    /// <summary>
    /// Delete one Common ATA Carnet Control
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonAtaCarnetControl(
        [FromRoute()] CommonAtaCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonAtaCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Common ATA Carnet Controls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonAtaCarnetControl>>> CommonAtaCarnetControls(
        [FromQuery()] CommonAtaCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.CommonAtaCarnetControls(filter));
    }

    /// <summary>
    /// Meta data about Common ATA Carnet Control records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonAtaCarnetControlsMeta(
        [FromQuery()] CommonAtaCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.CommonAtaCarnetControlsMeta(filter));
    }

    /// <summary>
    /// Get one Common ATA Carnet Control
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonAtaCarnetControl>> CommonAtaCarnetControl(
        [FromRoute()] CommonAtaCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonAtaCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common ATA Carnet Control
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonAtaCarnetControl(
        [FromRoute()] CommonAtaCarnetControlWhereUniqueInput uniqueId,
        [FromQuery()] CommonAtaCarnetControlUpdateInput commonAtaCarnetControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonAtaCarnetControl(uniqueId, commonAtaCarnetControlUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
