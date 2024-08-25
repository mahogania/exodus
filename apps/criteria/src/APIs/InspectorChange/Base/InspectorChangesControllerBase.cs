using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorChangesControllerBase : ControllerBase
{
    protected readonly IInspectorChangesService _service;

    public InspectorChangesControllerBase(IInspectorChangesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Change
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorChange>> CreateInspectorChange(
        InspectorChangeCreateInput input
    )
    {
        var inspectorChange = await _service.CreateInspectorChange(input);

        return CreatedAtAction(
            nameof(InspectorChange),
            new { id = inspectorChange.Id },
            inspectorChange
        );
    }

    /// <summary>
    /// Delete one Inspector Change
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorChange(
        [FromRoute()] InspectorChangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorChange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Changes
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<InspectorChange>>> InspectorChanges(
        [FromQuery()] InspectorChangeFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorChanges(filter));
    }

    /// <summary>
    /// Meta data about Inspector Change records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorChangesMeta(
        [FromQuery()] InspectorChangeFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorChangesMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Change
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorChange>> InspectorChange(
        [FromRoute()] InspectorChangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorChange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Inspector Change
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorChange(
        [FromRoute()] InspectorChangeWhereUniqueInput uniqueId,
        [FromQuery()] InspectorChangeUpdateInput inspectorChangeUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorChange(uniqueId, inspectorChangeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
