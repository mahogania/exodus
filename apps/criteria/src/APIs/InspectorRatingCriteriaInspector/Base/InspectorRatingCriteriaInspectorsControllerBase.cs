using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorRatingCriteriaInspectorsControllerBase : ControllerBase
{
    protected readonly IInspectorRatingCriteriaInspectorsService _service;

    public InspectorRatingCriteriaInspectorsControllerBase(
        IInspectorRatingCriteriaInspectorsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Rating Criteria Inspector
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InspectorRatingCriteriaInspector>
    > CreateInspectorRatingCriteriaInspector(InspectorRatingCriteriaInspectorCreateInput input)
    {
        var inspectorRatingCriteriaInspector =
            await _service.CreateInspectorRatingCriteriaInspector(input);

        return CreatedAtAction(
            nameof(InspectorRatingCriteriaInspector),
            new { id = inspectorRatingCriteriaInspector.Id },
            inspectorRatingCriteriaInspector
        );
    }

    /// <summary>
    /// Delete one Inspector Rating Criteria Inspector
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorRatingCriteriaInspector(
        [FromRoute()] InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorRatingCriteriaInspector(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Rating Criteria Inspectors
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InspectorRatingCriteriaInspector>>
    > InspectorRatingCriteriaInspectors(
        [FromQuery()] InspectorRatingCriteriaInspectorFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingCriteriaInspectors(filter));
    }

    /// <summary>
    /// Meta data about Inspector Rating Criteria Inspector records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorRatingCriteriaInspectorsMeta(
        [FromQuery()] InspectorRatingCriteriaInspectorFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingCriteriaInspectorsMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Rating Criteria Inspector
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InspectorRatingCriteriaInspector>
    > InspectorRatingCriteriaInspector(
        [FromRoute()] InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorRatingCriteriaInspector(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Inspector Rating Criteria Inspector
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorRatingCriteriaInspector(
        [FromRoute()] InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId,
        [FromQuery()]
            InspectorRatingCriteriaInspectorUpdateInput inspectorRatingCriteriaInspectorUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorRatingCriteriaInspector(
                uniqueId,
                inspectorRatingCriteriaInspectorUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Inspector Rating Criteria record for Inspector Rating Criteria Inspector
    /// </summary>
    [HttpGet("{Id}/inspectorRatingCriteria")]
    public async Task<ActionResult<List<InspectorRatingCriterion>>> GetInspectorRatingCriteria(
        [FromRoute()] InspectorRatingCriteriaInspectorWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriterion = await _service.GetInspectorRatingCriteria(uniqueId);
        return Ok(inspectorRatingCriterion);
    }
}
