using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorRatingCriteriaDeclarationModelsControllerBase : ControllerBase
{
    protected readonly IInspectorRatingCriteriaDeclarationModelsService _service;

    public InspectorRatingCriteriaDeclarationModelsControllerBase(
        IInspectorRatingCriteriaDeclarationModelsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Rating Criteria Declaration Model
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InspectorRatingCriteriaDeclarationModel>
    > CreateInspectorRatingCriteriaDeclarationModel(
        InspectorRatingCriteriaDeclarationModelCreateInput input
    )
    {
        var inspectorRatingCriteriaDeclarationModel =
            await _service.CreateInspectorRatingCriteriaDeclarationModel(input);

        return CreatedAtAction(
            nameof(InspectorRatingCriteriaDeclarationModel),
            new { id = inspectorRatingCriteriaDeclarationModel.Id },
            inspectorRatingCriteriaDeclarationModel
        );
    }

    /// <summary>
    /// Delete one Inspector Rating Criteria Declaration Model
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorRatingCriteriaDeclarationModel(
        [FromRoute()] InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorRatingCriteriaDeclarationModel(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Rating Criteria Declaration Models
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InspectorRatingCriteriaDeclarationModel>>
    > InspectorRatingCriteriaDeclarationModels(
        [FromQuery()] InspectorRatingCriteriaDeclarationModelFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingCriteriaDeclarationModels(filter));
    }

    /// <summary>
    /// Meta data about Inspector Rating Criteria Declaration Model records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorRatingCriteriaDeclarationModelsMeta(
        [FromQuery()] InspectorRatingCriteriaDeclarationModelFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingCriteriaDeclarationModelsMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Rating Criteria Declaration Model
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InspectorRatingCriteriaDeclarationModel>
    > InspectorRatingCriteriaDeclarationModel(
        [FromRoute()] InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorRatingCriteriaDeclarationModel(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Inspector Rating Criteria Declaration Model
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorRatingCriteriaDeclarationModel(
        [FromRoute()] InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId,
        [FromQuery()]
            InspectorRatingCriteriaDeclarationModelUpdateInput inspectorRatingCriteriaDeclarationModelUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorRatingCriteriaDeclarationModel(
                uniqueId,
                inspectorRatingCriteriaDeclarationModelUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Inspector Rating Criteria record for Inspector Rating Criteria Declaration Model
    /// </summary>
    [HttpGet("{Id}/inspectorRatingCriteria")]
    public async Task<ActionResult<List<InspectorRatingCriterion>>> GetInspectorRatingCriteria(
        [FromRoute()] InspectorRatingCriteriaDeclarationModelWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingCriterion = await _service.GetInspectorRatingCriteria(uniqueId);
        return Ok(inspectorRatingCriterion);
    }
}
