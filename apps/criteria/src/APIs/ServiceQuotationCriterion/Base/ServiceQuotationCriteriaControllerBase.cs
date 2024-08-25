using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ServiceQuotationCriteriaControllerBase : ControllerBase
{
    protected readonly IServiceQuotationCriteriaService _service;

    public ServiceQuotationCriteriaControllerBase(IServiceQuotationCriteriaService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Service Quotation Criterion
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ServiceQuotationCriterion>> CreateServiceQuotationCriterion(
        ServiceQuotationCriterionCreateInput input
    )
    {
        var serviceQuotationCriterion = await _service.CreateServiceQuotationCriterion(input);

        return CreatedAtAction(
            nameof(ServiceQuotationCriterion),
            new { id = serviceQuotationCriterion.Id },
            serviceQuotationCriterion
        );
    }

    /// <summary>
    /// Delete one Service Quotation Criterion
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteServiceQuotationCriterion(
        [FromRoute()] ServiceQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteServiceQuotationCriterion(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Service Quotation Criteria
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ServiceQuotationCriterion>>> ServiceQuotationCriteria(
        [FromQuery()] ServiceQuotationCriterionFindManyArgs filter
    )
    {
        return Ok(await _service.ServiceQuotationCriteria(filter));
    }

    /// <summary>
    /// Meta data about Service Quotation Criterion records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ServiceQuotationCriteriaMeta(
        [FromQuery()] ServiceQuotationCriterionFindManyArgs filter
    )
    {
        return Ok(await _service.ServiceQuotationCriteriaMeta(filter));
    }

    /// <summary>
    /// Get one Service Quotation Criterion
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ServiceQuotationCriterion>> ServiceQuotationCriterion(
        [FromRoute()] ServiceQuotationCriterionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ServiceQuotationCriterion(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Service Quotation Criterion
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateServiceQuotationCriterion(
        [FromRoute()] ServiceQuotationCriterionWhereUniqueInput uniqueId,
        [FromQuery()] ServiceQuotationCriterionUpdateInput serviceQuotationCriterionUpdateDto
    )
    {
        try
        {
            await _service.UpdateServiceQuotationCriterion(
                uniqueId,
                serviceQuotationCriterionUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
