using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Statement.APIs;
using Statement.APIs.Common;
using Statement.APIs.Dtos;
using Statement.APIs.Errors;

namespace Statement.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AttachmentsControllerBase : ControllerBase
{
    protected readonly IAttachmentsService _service;

    public AttachmentsControllerBase(IAttachmentsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Attachment
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Attachment>> CreateAttachment(AttachmentCreateInput input)
    {
        var attachment = await _service.CreateAttachment(input);

        return CreatedAtAction(nameof(Attachment), new { id = attachment.Id }, attachment);
    }

    /// <summary>
    /// Delete one Attachment
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAttachment(
        [FromRoute()] AttachmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAttachment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Attachments
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Attachment>>> Attachments(
        [FromQuery()] AttachmentFindManyArgs filter
    )
    {
        return Ok(await _service.Attachments(filter));
    }

    /// <summary>
    /// Meta data about Attachment records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AttachmentsMeta(
        [FromQuery()] AttachmentFindManyArgs filter
    )
    {
        return Ok(await _service.AttachmentsMeta(filter));
    }

    /// <summary>
    /// Get one Attachment
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Attachment>> Attachment(
        [FromRoute()] AttachmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Attachment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Attachment
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAttachment(
        [FromRoute()] AttachmentWhereUniqueInput uniqueId,
        [FromQuery()] AttachmentUpdateInput attachmentUpdateDto
    )
    {
        try
        {
            await _service.UpdateAttachment(uniqueId, attachmentUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
