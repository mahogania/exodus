using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticleAssessmentsControllerBase : ControllerBase
{
    protected readonly IArticleAssessmentsService _service;

    public ArticleAssessmentsControllerBase(IArticleAssessmentsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Article Assessment
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleAssessment>> CreateArticleAssessment(
        ArticleAssessmentCreateInput input
    )
    {
        var articleAssessment = await _service.CreateArticleAssessment(input);

        return CreatedAtAction(
            nameof(ArticleAssessment),
            new { id = articleAssessment.Id },
            articleAssessment
        );
    }

    /// <summary>
    /// Delete one Article Assessment
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticleAssessment(
        [FromRoute()] ArticleAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticleAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Assessment Articles
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleAssessment>>> ArticleAssessments(
        [FromQuery()] ArticleAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleAssessments(filter));
    }

    /// <summary>
    /// Meta data about Article Assessment records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticleAssessmentsMeta(
        [FromQuery()] ArticleAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleAssessmentsMeta(filter));
    }

    /// <summary>
    /// Get one Article Assessment
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleAssessment>> ArticleAssessment(
        [FromRoute()] ArticleAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticleAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Article Assessment
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleAssessment(
        [FromRoute()] ArticleAssessmentWhereUniqueInput uniqueId,
        [FromQuery()] ArticleAssessmentUpdateInput articleAssessmentUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticleAssessment(uniqueId, articleAssessmentUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Article record for Article Assessment
    /// </summary>
    [HttpGet("{Id}/articles")]
    public async Task<ActionResult<List<Article>>> GetArticle(
        [FromRoute()] ArticleAssessmentWhereUniqueInput uniqueId
    )
    {
        var article = await _service.GetArticle(uniqueId);
        return Ok(article);
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION (CUSTOMS) VALUE ASSESSMENT record for Assessment Article
    /// </summary>
    [HttpGet("{Id}/valueAssessments")]
    public async Task<ActionResult<List<ValueAssessment>>> GetValueAssessment(
        [FromRoute()] ArticleAssessmentWhereUniqueInput uniqueId
    )
    {
        var valueAssessment = await _service.GetValueAssessment(uniqueId);
        return Ok(valueAssessment);
    }
}
