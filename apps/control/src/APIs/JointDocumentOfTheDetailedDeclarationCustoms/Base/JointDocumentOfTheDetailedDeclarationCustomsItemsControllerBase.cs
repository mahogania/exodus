using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class JointDocumentOfTheDetailedDeclarationCustomsItemsControllerBase
    : ControllerBase
{
    protected readonly IJointDocumentOfTheDetailedDeclarationCustomsItemsService _service;

    public JointDocumentOfTheDetailedDeclarationCustomsItemsControllerBase(
        IJointDocumentOfTheDetailedDeclarationCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<JointDocumentOfTheDetailedDeclarationCustoms>
    > CreateJointDocumentOfTheDetailedDeclarationCustoms(
        JointDocumentOfTheDetailedDeclarationCustomsCreateInput input
    )
    {
        var jointDocumentOfTheDetailedDeclarationCustoms =
            await _service.CreateJointDocumentOfTheDetailedDeclarationCustoms(input);

        return CreatedAtAction(
            nameof(JointDocumentOfTheDetailedDeclarationCustoms),
            new { id = jointDocumentOfTheDetailedDeclarationCustoms.Id },
            jointDocumentOfTheDetailedDeclarationCustoms
        );
    }

    /// <summary>
    /// Delete one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteJointDocumentOfTheDetailedDeclarationCustoms(
        [FromRoute()] JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteJointDocumentOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<JointDocumentOfTheDetailedDeclarationCustoms>>
    > JointDocumentOfTheDetailedDeclarationCustomsItems(
        [FromQuery()] JointDocumentOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.JointDocumentOfTheDetailedDeclarationCustomsItems(filter));
    }

    /// <summary>
    /// Meta data about JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > JointDocumentOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery()] JointDocumentOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.JointDocumentOfTheDetailedDeclarationCustomsItemsMeta(filter));
    }

    /// <summary>
    /// Get one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<JointDocumentOfTheDetailedDeclarationCustoms>
    > JointDocumentOfTheDetailedDeclarationCustoms(
        [FromRoute()] JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.JointDocumentOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateJointDocumentOfTheDetailedDeclarationCustoms(
        [FromRoute()] JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery()]
            JointDocumentOfTheDetailedDeclarationCustomsUpdateInput jointDocumentOfTheDetailedDeclarationCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateJointDocumentOfTheDetailedDeclarationCustoms(
                uniqueId,
                jointDocumentOfTheDetailedDeclarationCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
