using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class NoticeOfDefaultsControllerBase : ControllerBase
{
    protected readonly INoticeOfDefaultsService _service;

    public NoticeOfDefaultsControllerBase(INoticeOfDefaultsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one NOTICE OF DEFAULT
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeOfDefault>> CreateNoticeOfDefault(
        NoticeOfDefaultCreateInput input
    )
    {
        var noticeOfDefault = await _service.CreateNoticeOfDefault(input);

        return CreatedAtAction(
            nameof(NoticeOfDefault),
            new { id = noticeOfDefault.Id },
            noticeOfDefault
        );
    }

    /// <summary>
    /// Delete one NOTICE OF DEFAULT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteNoticeOfDefault(
        [FromRoute()] NoticeOfDefaultWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteNoticeOfDefault(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many NOTICE OF DEFAULTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<NoticeOfDefault>>> NoticeOfDefaults(
        [FromQuery()] NoticeOfDefaultFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeOfDefaults(filter));
    }

    /// <summary>
    /// Meta data about NOTICE OF DEFAULT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> NoticeOfDefaultsMeta(
        [FromQuery()] NoticeOfDefaultFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeOfDefaultsMeta(filter));
    }

    /// <summary>
    /// Get one NOTICE OF DEFAULT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeOfDefault>> NoticeOfDefault(
        [FromRoute()] NoticeOfDefaultWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.NoticeOfDefault(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one NOTICE OF DEFAULT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateNoticeOfDefault(
        [FromRoute()] NoticeOfDefaultWhereUniqueInput uniqueId,
        [FromQuery()] NoticeOfDefaultUpdateInput noticeOfDefaultUpdateDto
    )
    {
        try
        {
            await _service.UpdateNoticeOfDefault(uniqueId, noticeOfDefaultUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
