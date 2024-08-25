using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorQuotationCriteriaControllerBase : ControllerBase
{
    protected readonly IInspectorQuotationCriteriaService _service;

    public InspectorQuotationCriteriaControllerBase(IInspectorQuotationCriteriaService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Quotation Criterion
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorQuotationCriterion>> CreateInspectorQuotationCriterion(
        InspectorQuotationCriterionCreateInput input
    )
    {
        var inspectorQuotationCriterion = await _service.CreateInspectorQuotationCriterion(input);

        return CreatedAtAction(
            nameof(InspectorQuotationCriterion),
            new { id = inspectorQuotationCriterion.Id },
            inspectorQuotationCriterion
        );
    }

    /// <summary>
    /// Delete one Inspector Quotation Criterion
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorQuotationCriterion(
        [FromRoute()] InspectorQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorQuotationCriterion(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Quotation Criteria
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<InspectorQuotationCriterion>>> InspectorQuotationCriteria(
        [FromQuery()] InspectorQuotationCriterionFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorQuotationCriteria(filter));
    }

    /// <summary>
    /// Meta data about Inspector Quotation Criterion records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorQuotationCriteriaMeta(
        [FromQuery()] InspectorQuotationCriterionFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorQuotationCriteriaMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Quotation Criterion
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorQuotationCriterion>> InspectorQuotationCriterion(
        [FromRoute()] InspectorQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorQuotationCriterion(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Inspector Quotation Criterion
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorQuotationCriterion(
        [FromRoute()] InspectorQuotationCriterionWhereUniqueInput uniqueId,
        [FromQuery()] InspectorQuotationCriterionUpdateInput inspectorQuotationCriterionUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorQuotationCriterion(
                uniqueId,
                inspectorQuotationCriterionUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
