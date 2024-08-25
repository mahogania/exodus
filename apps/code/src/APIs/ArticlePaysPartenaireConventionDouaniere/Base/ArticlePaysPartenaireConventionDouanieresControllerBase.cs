using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticlePaysPartenaireConventionDouanieresControllerBase : ControllerBase
{
    protected readonly IArticlePaysPartenaireConventionDouanieresService _service;

    public ArticlePaysPartenaireConventionDouanieresControllerBase(
        IArticlePaysPartenaireConventionDouanieresService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePaysPartenaireConventionDouaniere>
    > CreateArticlePaysPartenaireConventionDouaniere(
        ArticlePaysPartenaireConventionDouaniereCreateInput input
    )
    {
        var articlePaysPartenaireConventionDouaniere =
            await _service.CreateArticlePaysPartenaireConventionDouaniere(input);

        return CreatedAtAction(
            nameof(ArticlePaysPartenaireConventionDouaniere),
            new { id = articlePaysPartenaireConventionDouaniere.Id },
            articlePaysPartenaireConventionDouaniere
        );
    }

    /// <summary>
    /// Delete one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticlePaysPartenaireConventionDouaniere(
        [FromRoute()] ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticlePaysPartenaireConventionDouaniere(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ArticlePaysPartenaireConventionDouanieres
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ArticlePaysPartenaireConventionDouaniere>>
    > ArticlePaysPartenaireConventionDouanieres(
        [FromQuery()] ArticlePaysPartenaireConventionDouaniereFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePaysPartenaireConventionDouanieres(filter));
    }

    /// <summary>
    /// Meta data about ArticlePaysPartenaireConventionDouaniere records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticlePaysPartenaireConventionDouanieresMeta(
        [FromQuery()] ArticlePaysPartenaireConventionDouaniereFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePaysPartenaireConventionDouanieresMeta(filter));
    }

    /// <summary>
    /// Get one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePaysPartenaireConventionDouaniere>
    > ArticlePaysPartenaireConventionDouaniere(
        [FromRoute()] ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticlePaysPartenaireConventionDouaniere(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ArticlePaysPartenaireConventionDouaniere
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticlePaysPartenaireConventionDouaniere(
        [FromRoute()] ArticlePaysPartenaireConventionDouaniereWhereUniqueInput uniqueId,
        [FromQuery()]
            ArticlePaysPartenaireConventionDouaniereUpdateInput articlePaysPartenaireConventionDouaniereUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticlePaysPartenaireConventionDouaniere(
                uniqueId,
                articlePaysPartenaireConventionDouaniereUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
