using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class NoticeCancellationsControllerBase : ControllerBase
{
    protected readonly INoticeCancellationsService _service;

    public NoticeCancellationsControllerBase(INoticeCancellationsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one NOTICE CANCELLATION
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeCancellation>> CreateNoticeCancellation(
        NoticeCancellationCreateInput input
    )
    {
        var noticeCancellation = await _service.CreateNoticeCancellation(input);

        return CreatedAtAction(
            nameof(NoticeCancellation),
            new { id = noticeCancellation.Id },
            noticeCancellation
        );
    }

    /// <summary>
    ///     Delete one NOTICE CANCELLATION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteNoticeCancellation(
        [FromRoute] NoticeCancellationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteNoticeCancellation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many NOTICE CANCELLATIONS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<NoticeCancellation>>> NoticeCancellations(
        [FromQuery] NoticeCancellationFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeCancellations(filter));
    }

    /// <summary>
    ///     Meta data about NOTICE CANCELLATION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> NoticeCancellationsMeta(
        [FromQuery] NoticeCancellationFindManyArgs filter
    )
    {
        return Ok(await _service.NoticeCancellationsMeta(filter));
    }

    /// <summary>
    ///     Get one NOTICE CANCELLATION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<NoticeCancellation>> NoticeCancellation(
        [FromRoute] NoticeCancellationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.NoticeCancellation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one NOTICE CANCELLATION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateNoticeCancellation(
        [FromRoute] NoticeCancellationWhereUniqueInput uniqueId,
        [FromQuery] NoticeCancellationUpdateInput noticeCancellationUpdateDto
    )
    {
        try
        {
            await _service.UpdateNoticeCancellation(uniqueId, noticeCancellationUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
