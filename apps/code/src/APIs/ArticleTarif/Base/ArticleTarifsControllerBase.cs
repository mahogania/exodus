using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticleTarifsControllerBase : ControllerBase
{
    protected readonly IArticleTarifsService _service;

    public ArticleTarifsControllerBase(IArticleTarifsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ArticleTarif
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleTarif>> CreateArticleTarif(ArticleTarifCreateInput input)
    {
        var articleTarif = await _service.CreateArticleTarif(input);

        return CreatedAtAction(nameof(ArticleTarif), new { id = articleTarif.Id }, articleTarif);
    }

    /// <summary>
    /// Delete one ArticleTarif
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticleTarif(
        [FromRoute()] ArticleTarifWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticleTarif(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ArticleTarifs
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleTarif>>> ArticleTarifs(
        [FromQuery()] ArticleTarifFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleTarifs(filter));
    }

    /// <summary>
    /// Meta data about ArticleTarif records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticleTarifsMeta(
        [FromQuery()] ArticleTarifFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleTarifsMeta(filter));
    }

    /// <summary>
    /// Get one ArticleTarif
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleTarif>> ArticleTarif(
        [FromRoute()] ArticleTarifWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticleTarif(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ArticleTarif
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleTarif(
        [FromRoute()] ArticleTarifWhereUniqueInput uniqueId,
        [FromQuery()] ArticleTarifUpdateInput articleTarifUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticleTarif(uniqueId, articleTarifUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
