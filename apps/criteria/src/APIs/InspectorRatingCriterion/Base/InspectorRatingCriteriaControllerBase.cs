using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorRatingCriteriaControllerBase : ControllerBase
{
    protected readonly IInspectorRatingCriteriaService _service;

    public InspectorRatingCriteriaControllerBase(IInspectorRatingCriteriaService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Quotation Criterion
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorRatingCriterion>> CreateInspectorRatingCriterion(
        InspectorRatingCriterionCreateInput input
    )
    {
        var inspectorRatingCriterion = await _service.CreateInspectorRatingCriterion(input);

        return CreatedAtAction(
            nameof(InspectorRatingCriterion),
            new { id = inspectorRatingCriterion.Id },
            inspectorRatingCriterion
        );
    }

    /// <summary>
    /// Delete one Inspector Quotation Criterion
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorRatingCriterion(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorRatingCriterion(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Rating Criteria
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<InspectorRatingCriterion>>> InspectorRatingCriteria(
        [FromQuery()] InspectorRatingCriterionFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingCriteria(filter));
    }

    /// <summary>
    /// Meta data about Inspector Quotation Criterion records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorRatingCriteriaMeta(
        [FromQuery()] InspectorRatingCriterionFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingCriteriaMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Quotation Criterion
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorRatingCriterion>> InspectorRatingCriterion(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorRatingCriterion(uniqueId);
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
    public async Task<ActionResult> UpdateInspectorRatingCriterion(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromQuery()] InspectorRatingCriterionUpdateInput inspectorRatingCriterionUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorRatingCriterion(
                uniqueId,
                inspectorRatingCriterionUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple  Inspector Rating Criteria Declaration Model  records to Inspector Quotation Criterion
    /// </summary>
    [HttpPost("{Id}/inspectorRatingCriteriaDeclarationModels")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectInspectorRatingCriteriaDeclarationModel(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromQuery()]
            InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    )
    {
        try
        {
            await _service.ConnectInspectorRatingCriteriaDeclarationModel(
                uniqueId,
                inspectorRatingCriteriaDeclarationModelsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple  Inspector Rating Criteria Declaration Model  records from Inspector Quotation Criterion
    /// </summary>
    [HttpDelete("{Id}/inspectorRatingCriteriaDeclarationModels")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectInspectorRatingCriteriaDeclarationModel(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromBody()]
            InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    )
    {
        try
        {
            await _service.DisconnectInspectorRatingCriteriaDeclarationModel(
                uniqueId,
                inspectorRatingCriteriaDeclarationModelsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple  Inspector Rating Criteria Declaration Model  records for Inspector Quotation Criterion
    /// </summary>
    [HttpGet("{Id}/inspectorRatingCriteriaDeclarationModels")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InspectorRatingCriteriaDeclarationModel>>
    > FindInspectorRatingCriteriaDeclarationModel(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromQuery()] InspectorRatingCriteriaDeclarationModelFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindInspectorRatingCriteriaDeclarationModel(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple  Inspector Rating Criteria Declaration Model  records for Inspector Quotation Criterion
    /// </summary>
    [HttpPatch("{Id}/inspectorRatingCriteriaDeclarationModels")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorRatingCriteriaDeclarationModel(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromBody()]
            InspectorRatingCriteriaDeclarationModelWhereUniqueInput[] inspectorRatingCriteriaDeclarationModelsId
    )
    {
        try
        {
            await _service.UpdateInspectorRatingCriteriaDeclarationModel(
                uniqueId,
                inspectorRatingCriteriaDeclarationModelsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Inspector Rating Criteria Inspector records to Inspector Quotation Criterion
    /// </summary>
    [HttpPost("{Id}/inspectorRatingCriteriaInspectors")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectInspectorRatingCriteriaInspector(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromQuery()]
            InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    )
    {
        try
        {
            await _service.ConnectInspectorRatingCriteriaInspector(
                uniqueId,
                inspectorRatingCriteriaInspectorsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Inspector Rating Criteria Inspector records from Inspector Quotation Criterion
    /// </summary>
    [HttpDelete("{Id}/inspectorRatingCriteriaInspectors")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectInspectorRatingCriteriaInspector(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromBody()]
            InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    )
    {
        try
        {
            await _service.DisconnectInspectorRatingCriteriaInspector(
                uniqueId,
                inspectorRatingCriteriaInspectorsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Inspector Rating Criteria Inspector records for Inspector Quotation Criterion
    /// </summary>
    [HttpGet("{Id}/inspectorRatingCriteriaInspectors")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InspectorRatingCriteriaInspector>>
    > FindInspectorRatingCriteriaInspector(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromQuery()] InspectorRatingCriteriaInspectorFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindInspectorRatingCriteriaInspector(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Inspector Rating Criteria Inspector records for Inspector Quotation Criterion
    /// </summary>
    [HttpPatch("{Id}/inspectorRatingCriteriaInspectors")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorRatingCriteriaInspector(
        [FromRoute()] InspectorRatingCriterionWhereUniqueInput uniqueId,
        [FromBody()]
            InspectorRatingCriteriaInspectorWhereUniqueInput[] inspectorRatingCriteriaInspectorsId
    )
    {
        try
        {
            await _service.UpdateInspectorRatingCriteriaInspector(
                uniqueId,
                inspectorRatingCriteriaInspectorsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
