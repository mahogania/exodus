using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class CommonDetailedDeclarationCustomsValueAssessmentsControllerBase
    : ControllerBase
{
    protected readonly ICommonDetailedDeclarationCustomsValueAssessmentsService _service;

    public CommonDetailedDeclarationCustomsValueAssessmentsControllerBase(
        ICommonDetailedDeclarationCustomsValueAssessmentsService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CommonDetailedDeclarationCustomsValueAssessment>
    > CreateCommonDetailedDeclarationCustomsValueAssessment(
        CommonDetailedDeclarationCustomsValueAssessmentCreateInput input
    )
    {
        var commonDetailedDeclarationCustomsValueAssessment =
            await _service.CreateCommonDetailedDeclarationCustomsValueAssessment(input);

        return CreatedAtAction(
            nameof(CommonDetailedDeclarationCustomsValueAssessment),
            new { id = commonDetailedDeclarationCustomsValueAssessment.Id },
            commonDetailedDeclarationCustomsValueAssessment
        );
    }

    /// <summary>
    ///     Delete one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonDetailedDeclarationCustomsValueAssessment(
        [FromRoute] CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonDetailedDeclarationCustomsValueAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<CommonDetailedDeclarationCustomsValueAssessment>>
    > CommonDetailedDeclarationCustomsValueAssessments(
        [FromQuery] CommonDetailedDeclarationCustomsValueAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.CommonDetailedDeclarationCustomsValueAssessments(filter));
    }

    /// <summary>
    ///     Meta data about COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > CommonDetailedDeclarationCustomsValueAssessmentsMeta(
        [FromQuery] CommonDetailedDeclarationCustomsValueAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.CommonDetailedDeclarationCustomsValueAssessmentsMeta(filter));
    }

    /// <summary>
    ///     Get one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CommonDetailedDeclarationCustomsValueAssessment>
    > CommonDetailedDeclarationCustomsValueAssessment(
        [FromRoute] CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonDetailedDeclarationCustomsValueAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonDetailedDeclarationCustomsValueAssessment(
        [FromRoute] CommonDetailedDeclarationCustomsValueAssessmentWhereUniqueInput uniqueId,
        [FromQuery] CommonDetailedDeclarationCustomsValueAssessmentUpdateInput
            commonDetailedDeclarationCustomsValueAssessmentUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonDetailedDeclarationCustomsValueAssessment(
                uniqueId,
                commonDetailedDeclarationCustomsValueAssessmentUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
