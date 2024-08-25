using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class ExpectedReimportReexportArticlesControllerBase : ControllerBase
{
    protected readonly IExpectedReimportReexportArticlesService _service;

    public ExpectedReimportReexportArticlesControllerBase(
        IExpectedReimportReexportArticlesService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ExpectedReimportReexportArticle>
    > CreateExpectedReimportReexportArticle(ExpectedReimportReexportArticleCreateInput input)
    {
        var expectedReimportReexportArticle = await _service.CreateExpectedReimportReexportArticle(
            input
        );

        return CreatedAtAction(
            nameof(ExpectedReimportReexportArticle),
            new { id = expectedReimportReexportArticle.Id },
            expectedReimportReexportArticle
        );
    }

    /// <summary>
    ///     Delete one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExpectedReimportReexportArticle(
        [FromRoute] ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteExpectedReimportReexportArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many EXPECTED REIMPORT/REEXPORT ARTICLES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ExpectedReimportReexportArticle>>
    > ExpectedReimportReexportArticles(
        [FromQuery] ExpectedReimportReexportArticleFindManyArgs filter
    )
    {
        return Ok(await _service.ExpectedReimportReexportArticles(filter));
    }

    /// <summary>
    ///     Meta data about EXPECTED REIMPORT/REEXPORT ARTICLE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExpectedReimportReexportArticlesMeta(
        [FromQuery] ExpectedReimportReexportArticleFindManyArgs filter
    )
    {
        return Ok(await _service.ExpectedReimportReexportArticlesMeta(filter));
    }

    /// <summary>
    ///     Get one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ExpectedReimportReexportArticle>
    > ExpectedReimportReexportArticle(
        [FromRoute] ExpectedReimportReexportArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ExpectedReimportReexportArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one EXPECTED REIMPORT/REEXPORT ARTICLE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExpectedReimportReexportArticle(
        [FromRoute] ExpectedReimportReexportArticleWhereUniqueInput uniqueId,
        [FromQuery] ExpectedReimportReexportArticleUpdateInput expectedReimportReexportArticleUpdateDto
    )
    {
        try
        {
            await _service.UpdateExpectedReimportReexportArticle(
                uniqueId,
                expectedReimportReexportArticleUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
