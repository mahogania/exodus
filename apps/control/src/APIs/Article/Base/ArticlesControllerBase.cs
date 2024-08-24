using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticlesControllerBase : ControllerBase
{
    protected readonly IArticlesService _service;

    public ArticlesControllerBase(IArticlesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Article
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Article>> CreateArticle(ArticleCreateInput input)
    {
        var article = await _service.CreateArticle(input);

        return CreatedAtAction(nameof(Article), new { id = article.Id }, article);
    }

    /// <summary>
    /// Delete one Article
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticle([FromRoute()] ArticleWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Articles of the Detailed Declaration
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Article>>> Articles(
        [FromQuery()] ArticleFindManyArgs filter
    )
    {
        return Ok(await _service.Articles(filter));
    }

    /// <summary>
    /// Meta data about Article records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticlesMeta(
        [FromQuery()] ArticleFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlesMeta(filter));
    }

    /// <summary>
    /// Get one Article
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Article>> Article([FromRoute()] ArticleWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Article(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Article
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticle(
        [FromRoute()] ArticleWhereUniqueInput uniqueId,
        [FromQuery()] ArticleUpdateInput articleUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticle(uniqueId, articleUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Article Assessments records to Article
    /// </summary>
    [HttpPost("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectArticleAssessments(
        [FromRoute()] ArticleWhereUniqueInput uniqueId,
        [FromQuery()] ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        try
        {
            await _service.ConnectArticleAssessments(uniqueId, articleAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Article Assessments records from Article
    /// </summary>
    [HttpDelete("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectArticleAssessments(
        [FromRoute()] ArticleWhereUniqueInput uniqueId,
        [FromBody()] ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        try
        {
            await _service.DisconnectArticleAssessments(uniqueId, articleAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Article Assessments records for Article
    /// </summary>
    [HttpGet("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleAssessment>>> FindArticleAssessments(
        [FromRoute()] ArticleWhereUniqueInput uniqueId,
        [FromQuery()] ArticleAssessmentFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindArticleAssessments(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Article Assessments records for Article
    /// </summary>
    [HttpPatch("{Id}/articleAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleAssessments(
        [FromRoute()] ArticleWhereUniqueInput uniqueId,
        [FromBody()] ArticleAssessmentWhereUniqueInput[] articleAssessmentsId
    )
    {
        try
        {
            await _service.UpdateArticleAssessments(uniqueId, articleAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}/commonDetailedDeclarations")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> GetCommonDetailedDeclaration(
        [FromRoute()] ArticleWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclaration(uniqueId);
        return Ok(commonDetailedDeclaration);
    }

    /// <summary>
    /// Get a Tax record for Article
    /// </summary>
    [HttpGet("{Id}/detailedDeclarationTaxes")]
    public async Task<ActionResult<List<DetailedDeclarationTax>>> GetTax(
        [FromRoute()] ArticleWhereUniqueInput uniqueId
    )
    {
        var detailedDeclarationTax = await _service.GetTax(uniqueId);
        return Ok(detailedDeclarationTax);
    }
}
