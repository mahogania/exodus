using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorVerifierDesignationsControllerBase : ControllerBase
{
    protected readonly IInspectorVerifierDesignationsService _service;

    public InspectorVerifierDesignationsControllerBase(
        IInspectorVerifierDesignationsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Verifier Designation
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InspectorVerifierDesignation>
    > CreateInspectorVerifierDesignation(InspectorVerifierDesignationCreateInput input)
    {
        var inspectorVerifierDesignation = await _service.CreateInspectorVerifierDesignation(input);

        return CreatedAtAction(
            nameof(InspectorVerifierDesignation),
            new { id = inspectorVerifierDesignation.Id },
            inspectorVerifierDesignation
        );
    }

    /// <summary>
    /// Delete one Inspector Verifier Designation
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorVerifierDesignation(
        [FromRoute()] InspectorVerifierDesignationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorVerifierDesignation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Verifier Designations
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InspectorVerifierDesignation>>
    > InspectorVerifierDesignations([FromQuery()] InspectorVerifierDesignationFindManyArgs filter)
    {
        return Ok(await _service.InspectorVerifierDesignations(filter));
    }

    /// <summary>
    /// Meta data about Inspector Verifier Designation records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorVerifierDesignationsMeta(
        [FromQuery()] InspectorVerifierDesignationFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorVerifierDesignationsMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Verifier Designation
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorVerifierDesignation>> InspectorVerifierDesignation(
        [FromRoute()] InspectorVerifierDesignationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorVerifierDesignation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Inspector Verifier Designation
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorVerifierDesignation(
        [FromRoute()] InspectorVerifierDesignationWhereUniqueInput uniqueId,
        [FromQuery()] InspectorVerifierDesignationUpdateInput inspectorVerifierDesignationUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorVerifierDesignation(
                uniqueId,
                inspectorVerifierDesignationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
