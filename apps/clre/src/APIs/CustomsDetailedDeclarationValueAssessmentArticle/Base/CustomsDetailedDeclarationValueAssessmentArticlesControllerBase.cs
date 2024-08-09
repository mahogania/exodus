using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CustomsDetailedDeclarationValueAssessmentArticlesControllerBase
    : ControllerBase
{
    protected readonly ICustomsDetailedDeclarationValueAssessmentArticlesService _service;

    public CustomsDetailedDeclarationValueAssessmentArticlesControllerBase(
        ICustomsDetailedDeclarationValueAssessmentArticlesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CustomsDetailedDeclarationValueAssessmentArticle>
    > CreateCustomsDetailedDeclarationValueAssessmentArticle(
        CustomsDetailedDeclarationValueAssessmentArticleCreateInput input
    )
    {
        var customsDetailedDeclarationValueAssessmentArticle =
            await _service.CreateCustomsDetailedDeclarationValueAssessmentArticle(input);

        return CreatedAtAction(
            nameof(CustomsDetailedDeclarationValueAssessmentArticle),
            new { id = customsDetailedDeclarationValueAssessmentArticle.Id },
            customsDetailedDeclarationValueAssessmentArticle
        );
    }

    /// <summary>
    /// Delete one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCustomsDetailedDeclarationValueAssessmentArticle(
        [FromRoute()] CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCustomsDetailedDeclarationValueAssessmentArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<CustomsDetailedDeclarationValueAssessmentArticle>>
    > CustomsDetailedDeclarationValueAssessmentArticles(
        [FromQuery()] CustomsDetailedDeclarationValueAssessmentArticleFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsDetailedDeclarationValueAssessmentArticles(filter));
    }

    /// <summary>
    /// Meta data about CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > CustomsDetailedDeclarationValueAssessmentArticlesMeta(
        [FromQuery()] CustomsDetailedDeclarationValueAssessmentArticleFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsDetailedDeclarationValueAssessmentArticlesMeta(filter));
    }

    /// <summary>
    /// Get one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CustomsDetailedDeclarationValueAssessmentArticle>
    > CustomsDetailedDeclarationValueAssessmentArticle(
        [FromRoute()] CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CustomsDetailedDeclarationValueAssessmentArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one CUSTOMS DETAILED DECLARATION VALUE ASSESSMENT ARTICLE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCustomsDetailedDeclarationValueAssessmentArticle(
        [FromRoute()] CustomsDetailedDeclarationValueAssessmentArticleWhereUniqueInput uniqueId,
        [FromQuery()]
            CustomsDetailedDeclarationValueAssessmentArticleUpdateInput customsDetailedDeclarationValueAssessmentArticleUpdateDto
    )
    {
        try
        {
            await _service.UpdateCustomsDetailedDeclarationValueAssessmentArticle(
                uniqueId,
                customsDetailedDeclarationValueAssessmentArticleUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
