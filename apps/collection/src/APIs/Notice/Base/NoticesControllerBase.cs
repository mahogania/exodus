using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class NoticesControllerBase : ControllerBase
{
    protected readonly INoticesService _service;

    public NoticesControllerBase(INoticesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one NOTICE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Notice>> CreateNotice(NoticeCreateInput input)
    {
        var notice = await _service.CreateNotice(input);

        return CreatedAtAction(nameof(Notice), new { id = notice.Id }, notice);
    }

    /// <summary>
    ///     Delete one NOTICE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteNotice([FromRoute] NoticeWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteNotice(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many NOTICES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Notice>>> Notices([FromQuery] NoticeFindManyArgs filter)
    {
        return Ok(await _service.Notices(filter));
    }

    /// <summary>
    ///     Meta data about NOTICE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> NoticesMeta(
        [FromQuery] NoticeFindManyArgs filter
    )
    {
        return Ok(await _service.NoticesMeta(filter));
    }

    /// <summary>
    ///     Get one NOTICE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Notice>> Notice([FromRoute] NoticeWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Notice(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one NOTICE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateNotice(
        [FromRoute] NoticeWhereUniqueInput uniqueId,
        [FromQuery] NoticeUpdateInput noticeUpdateDto
    )
    {
        try
        {
            await _service.UpdateNotice(uniqueId, noticeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
