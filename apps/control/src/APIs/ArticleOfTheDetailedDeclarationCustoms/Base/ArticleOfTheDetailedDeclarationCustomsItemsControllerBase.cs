using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticleOfTheDetailedDeclarationCustomsItemsControllerBase : ControllerBase
{
    protected readonly IArticleOfTheDetailedDeclarationCustomsItemsService _service;

    public ArticleOfTheDetailedDeclarationCustomsItemsControllerBase(
        IArticleOfTheDetailedDeclarationCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticleOfTheDetailedDeclarationCustoms>
    > CreateArticleOfTheDetailedDeclarationCustoms(
        ArticleOfTheDetailedDeclarationCustomsCreateInput input
    )
    {
        var articleOfTheDetailedDeclarationCustoms =
            await _service.CreateArticleOfTheDetailedDeclarationCustoms(input);

        return CreatedAtAction(
            nameof(ArticleOfTheDetailedDeclarationCustoms),
            new { id = articleOfTheDetailedDeclarationCustoms.Id },
            articleOfTheDetailedDeclarationCustoms
        );
    }

    /// <summary>
    /// Delete one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticleOfTheDetailedDeclarationCustoms(
        [FromRoute()] ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticleOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ArticleOfTheDetailedDeclarationCustoms>>
    > ArticleOfTheDetailedDeclarationCustomsItems(
        [FromQuery()] ArticleOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleOfTheDetailedDeclarationCustomsItems(filter));
    }

    /// <summary>
    /// Meta data about ARTICLE OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticleOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery()] ArticleOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleOfTheDetailedDeclarationCustomsItemsMeta(filter));
    }

    /// <summary>
    /// Get one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticleOfTheDetailedDeclarationCustoms>
    > ArticleOfTheDetailedDeclarationCustoms(
        [FromRoute()] ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticleOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ARTICLE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleOfTheDetailedDeclarationCustoms(
        [FromRoute()] ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery()]
            ArticleOfTheDetailedDeclarationCustomsUpdateInput articleOfTheDetailedDeclarationCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticleOfTheDetailedDeclarationCustoms(
                uniqueId,
                articleOfTheDetailedDeclarationCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
