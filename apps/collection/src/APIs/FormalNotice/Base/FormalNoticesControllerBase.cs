using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class FormalNoticesControllerBase : ControllerBase
{
    protected readonly IFormalNoticesService _service;

    public FormalNoticesControllerBase(IFormalNoticesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one FORMAL NOTICE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FormalNotice>> CreateFormalNotice(FormalNoticeCreateInput input)
    {
        var formalNotice = await _service.CreateFormalNotice(input);

        return CreatedAtAction(nameof(FormalNotice), new { id = formalNotice.Id }, formalNotice);
    }

    /// <summary>
    ///     Delete one FORMAL NOTICE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteFormalNotice(
        [FromRoute] FormalNoticeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteFormalNotice(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many FORMAL NOTICES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<FormalNotice>>> FormalNotices(
        [FromQuery] FormalNoticeFindManyArgs filter
    )
    {
        return Ok(await _service.FormalNotices(filter));
    }

    /// <summary>
    ///     Meta data about FORMAL NOTICE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> FormalNoticesMeta(
        [FromQuery] FormalNoticeFindManyArgs filter
    )
    {
        return Ok(await _service.FormalNoticesMeta(filter));
    }

    /// <summary>
    ///     Get one FORMAL NOTICE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FormalNotice>> FormalNotice(
        [FromRoute] FormalNoticeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.FormalNotice(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one FORMAL NOTICE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateFormalNotice(
        [FromRoute] FormalNoticeWhereUniqueInput uniqueId,
        [FromQuery] FormalNoticeUpdateInput formalNoticeUpdateDto
    )
    {
        try
        {
            await _service.UpdateFormalNotice(uniqueId, formalNoticeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
