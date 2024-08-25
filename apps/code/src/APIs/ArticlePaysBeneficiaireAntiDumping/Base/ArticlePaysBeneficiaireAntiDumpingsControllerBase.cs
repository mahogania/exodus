using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticlePaysBeneficiaireAntiDumpingsControllerBase : ControllerBase
{
    protected readonly IArticlePaysBeneficiaireAntiDumpingsService _service;

    public ArticlePaysBeneficiaireAntiDumpingsControllerBase(
        IArticlePaysBeneficiaireAntiDumpingsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePaysBeneficiaireAntiDumping>
    > CreateArticlePaysBeneficiaireAntiDumping(ArticlePaysBeneficiaireAntiDumpingCreateInput input)
    {
        var articlePaysBeneficiaireAntiDumping =
            await _service.CreateArticlePaysBeneficiaireAntiDumping(input);

        return CreatedAtAction(
            nameof(ArticlePaysBeneficiaireAntiDumping),
            new { id = articlePaysBeneficiaireAntiDumping.Id },
            articlePaysBeneficiaireAntiDumping
        );
    }

    /// <summary>
    /// Delete one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticlePaysBeneficiaireAntiDumping(
        [FromRoute()] ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticlePaysBeneficiaireAntiDumping(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ArticlePaysBeneficiaireAntiDumpings
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ArticlePaysBeneficiaireAntiDumping>>
    > ArticlePaysBeneficiaireAntiDumpings(
        [FromQuery()] ArticlePaysBeneficiaireAntiDumpingFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePaysBeneficiaireAntiDumpings(filter));
    }

    /// <summary>
    /// Meta data about ArticlePaysBeneficiaireAntiDumping records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticlePaysBeneficiaireAntiDumpingsMeta(
        [FromQuery()] ArticlePaysBeneficiaireAntiDumpingFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePaysBeneficiaireAntiDumpingsMeta(filter));
    }

    /// <summary>
    /// Get one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePaysBeneficiaireAntiDumping>
    > ArticlePaysBeneficiaireAntiDumping(
        [FromRoute()] ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticlePaysBeneficiaireAntiDumping(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ArticlePaysBeneficiaireAntiDumping
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticlePaysBeneficiaireAntiDumping(
        [FromRoute()] ArticlePaysBeneficiaireAntiDumpingWhereUniqueInput uniqueId,
        [FromQuery()]
            ArticlePaysBeneficiaireAntiDumpingUpdateInput articlePaysBeneficiaireAntiDumpingUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticlePaysBeneficiaireAntiDumping(
                uniqueId,
                articlePaysBeneficiaireAntiDumpingUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
