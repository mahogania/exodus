using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class NoticeTypesControllerBase : ControllerBase
{
    protected readonly INoticeTypesService _service;

    public NoticeTypesControllerBase(INoticeTypesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one NOTICE TYPE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeType>> CreateNoticeType(NoticeTypeCreateInput input)
    {
        var noticeType = await _service.CreateNoticeType(input);

        return CreatedAtAction(nameof(NoticeType), new { id = noticeType.Id }, noticeType);
    }

    /// <summary>
    ///     Delete one NOTICE TYPE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteNoticeType(
        [FromRoute] NoticeTypeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteNoticeType(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many NOTICE TYPES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<NoticeType>>> NoticeTypes(
        [FromQuery] NoticeTypeFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeTypes(filter));
    }

    /// <summary>
    ///     Meta data about NOTICE TYPE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> NoticeTypesMeta(
        [FromQuery] NoticeTypeFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeTypesMeta(filter));
    }

    /// <summary>
    ///     Get one NOTICE TYPE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeType>> NoticeType(
        [FromRoute] NoticeTypeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.NoticeType(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one NOTICE TYPE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateNoticeType(
        [FromRoute] NoticeTypeWhereUniqueInput uniqueId,
        [FromQuery] NoticeTypeUpdateInput noticeTypeUpdateDto
    )
    {
        try
        {
            await _service.UpdateNoticeType(uniqueId, noticeTypeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
