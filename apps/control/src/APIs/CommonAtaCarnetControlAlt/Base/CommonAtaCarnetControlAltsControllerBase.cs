using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonAtaCarnetControlAltsControllerBase : ControllerBase
{
    protected readonly ICommonAtaCarnetControlAltsService _service;

    public CommonAtaCarnetControlAltsControllerBase(ICommonAtaCarnetControlAltsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common ATA Carnet Control Alt
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonAtaCarnetControlAlt>> CreateCommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltCreateInput input
    )
    {
        var commonAtaCarnetControlAlt = await _service.CreateCommonAtaCarnetControlAlt(input);

        return CreatedAtAction(
            nameof(CommonAtaCarnetControlAlt),
            new { id = commonAtaCarnetControlAlt.Id },
            commonAtaCarnetControlAlt
        );
    }

    /// <summary>
    /// Delete one Common ATA Carnet Control Alt
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonAtaCarnetControlAlt(
        [FromRoute()] CommonAtaCarnetControlAltWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonAtaCarnetControlAlt(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Common ATA Carnet Control Alts
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonAtaCarnetControlAlt>>> CommonAtaCarnetControlAlts(
        [FromQuery()] CommonAtaCarnetControlAltFindManyArgs filter
    )
    {
        return Ok(await _service.CommonAtaCarnetControlAlts(filter));
    }

    /// <summary>
    /// Meta data about Common ATA Carnet Control Alt records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonAtaCarnetControlAltsMeta(
        [FromQuery()] CommonAtaCarnetControlAltFindManyArgs filter
    )
    {
        return Ok(await _service.CommonAtaCarnetControlAltsMeta(filter));
    }

    /// <summary>
    /// Get one Common ATA Carnet Control Alt
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonAtaCarnetControlAlt>> CommonAtaCarnetControlAlt(
        [FromRoute()] CommonAtaCarnetControlAltWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonAtaCarnetControlAlt(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common ATA Carnet Control Alt
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonAtaCarnetControlAlt(
        [FromRoute()] CommonAtaCarnetControlAltWhereUniqueInput uniqueId,
        [FromQuery()] CommonAtaCarnetControlAltUpdateInput commonAtaCarnetControlAltUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonAtaCarnetControlAlt(
                uniqueId,
                commonAtaCarnetControlAltUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
