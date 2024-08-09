using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class NoticeStaggeringsControllerBase : ControllerBase
{
    protected readonly INoticeStaggeringsService _service;

    public NoticeStaggeringsControllerBase(INoticeStaggeringsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one NOTICE STAGGERING
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeStaggering>> CreateNoticeStaggering(
        NoticeStaggeringCreateInput input
    )
    {
        var noticeStaggering = await _service.CreateNoticeStaggering(input);

        return CreatedAtAction(
            nameof(NoticeStaggering),
            new { id = noticeStaggering.Id },
            noticeStaggering
        );
    }

    /// <summary>
    /// Delete one NOTICE STAGGERING
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteNoticeStaggering(
        [FromRoute()] NoticeStaggeringWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteNoticeStaggering(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many NOTICE STAGGERINGS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<NoticeStaggering>>> NoticeStaggerings(
        [FromQuery()] NoticeStaggeringFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeStaggerings(filter));
    }

    /// <summary>
    /// Meta data about NOTICE STAGGERING records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> NoticeStaggeringsMeta(
        [FromQuery()] NoticeStaggeringFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeStaggeringsMeta(filter));
    }

    /// <summary>
    /// Get one NOTICE STAGGERING
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeStaggering>> NoticeStaggering(
        [FromRoute()] NoticeStaggeringWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.NoticeStaggering(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one NOTICE STAGGERING
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateNoticeStaggering(
        [FromRoute()] NoticeStaggeringWhereUniqueInput uniqueId,
        [FromQuery()] NoticeStaggeringUpdateInput noticeStaggeringUpdateDto
    )
    {
        try
        {
            await _service.UpdateNoticeStaggering(uniqueId, noticeStaggeringUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
