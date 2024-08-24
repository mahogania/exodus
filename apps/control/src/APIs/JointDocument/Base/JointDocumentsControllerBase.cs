using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class JointDocumentsControllerBase : ControllerBase
{
    protected readonly IJointDocumentsService _service;

    public JointDocumentsControllerBase(IJointDocumentsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Joint Document
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<JointDocument>> CreateJointDocument(
        JointDocumentCreateInput input
    )
    {
        var jointDocument = await _service.CreateJointDocument(input);

        return CreatedAtAction(nameof(JointDocument), new { id = jointDocument.Id }, jointDocument);
    }

    /// <summary>
    /// Delete one Joint Document
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteJointDocument(
        [FromRoute()] JointDocumentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteJointDocument(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Joint Documents
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<JointDocument>>> JointDocuments(
        [FromQuery()] JointDocumentFindManyArgs filter
    )
    {
        return Ok(await _service.JointDocuments(filter));
    }

    /// <summary>
    /// Meta data about Joint Document records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> JointDocumentsMeta(
        [FromQuery()] JointDocumentFindManyArgs filter
    )
    {
        return Ok(await _service.JointDocumentsMeta(filter));
    }

    /// <summary>
    /// Get one Joint Document
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<JointDocument>> JointDocument(
        [FromRoute()] JointDocumentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.JointDocument(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Joint Document
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateJointDocument(
        [FromRoute()] JointDocumentWhereUniqueInput uniqueId,
        [FromQuery()] JointDocumentUpdateInput jointDocumentUpdateDto
    )
    {
        try
        {
            await _service.UpdateJointDocument(uniqueId, jointDocumentUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}/commonDetailedDeclarations")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> GetCommonDetailedDeclaration(
        [FromRoute()] JointDocumentWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclaration(uniqueId);
        return Ok(commonDetailedDeclaration);
    }
}
