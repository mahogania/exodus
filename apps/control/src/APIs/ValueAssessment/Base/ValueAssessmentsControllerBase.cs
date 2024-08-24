using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ValueAssessmentsControllerBase : ControllerBase
{
    protected readonly IValueAssessmentsService _service;

    public ValueAssessmentsControllerBase(IValueAssessmentsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Value Assessment
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ValueAssessment>> CreateValueAssessment(
        ValueAssessmentCreateInput input
    )
    {
        var valueAssessment = await _service.CreateValueAssessment(input);

        return CreatedAtAction(
            nameof(ValueAssessment),
            new { id = valueAssessment.Id },
            valueAssessment
        );
    }

    /// <summary>
    /// Delete one Value Assessment
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteValueAssessment(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteValueAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Value Assessments
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ValueAssessment>>> ValueAssessments(
        [FromQuery()] ValueAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.ValueAssessments(filter));
    }

    /// <summary>
    /// Meta data about Value Assessment records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ValueAssessmentsMeta(
        [FromQuery()] ValueAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.ValueAssessmentsMeta(filter));
    }

    /// <summary>
    /// Get one Value Assessment
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ValueAssessment>> ValueAssessment(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ValueAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Value Assessment
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateValueAssessment(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId,
        [FromQuery()] ValueAssessmentUpdateInput valueAssessmentUpdateDto
    )
    {
        try
        {
            await _service.UpdateValueAssessment(uniqueId, valueAssessmentUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Articles records to Value Assessment
    /// </summary>
    [HttpPost("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectArticles(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId,
        [FromQuery()] ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        try
        {
            await _service.ConnectArticles(uniqueId, articleAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Articles records from Value Assessment
    /// </summary>
    [HttpDelete("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectArticles(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId,
        [FromBody()] ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        try
        {
            await _service.DisconnectArticles(uniqueId, articleAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Articles records for Value Assessment
    /// </summary>
    [HttpGet("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleAssessment>>> FindArticles(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId,
        [FromQuery()] ArticleAssessmentFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindArticles(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Articles records for Value Assessment
    /// </summary>
    [HttpPatch("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticles(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId,
        [FromBody()] ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        try
        {
            await _service.UpdateArticles(uniqueId, articleAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Detailed Declarations record for COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    [HttpGet("{Id}/commonDetailedDeclarations")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> GetCommonDetailedDeclarations(
        [FromRoute()] ValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclarations(uniqueId);
        return Ok(commonDetailedDeclaration);
    }
}
