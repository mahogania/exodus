using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticlePeriodeApplicationTarifNormalsControllerBase : ControllerBase
{
    protected readonly IArticlePeriodeApplicationTarifNormalsService _service;

    public ArticlePeriodeApplicationTarifNormalsControllerBase(
        IArticlePeriodeApplicationTarifNormalsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePeriodeApplicationTarifNormal>
    > CreateArticlePeriodeApplicationTarifNormal(
        ArticlePeriodeApplicationTarifNormalCreateInput input
    )
    {
        var articlePeriodeApplicationTarifNormal =
            await _service.CreateArticlePeriodeApplicationTarifNormal(input);

        return CreatedAtAction(
            nameof(ArticlePeriodeApplicationTarifNormal),
            new { id = articlePeriodeApplicationTarifNormal.Id },
            articlePeriodeApplicationTarifNormal
        );
    }

    /// <summary>
    /// Delete one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticlePeriodeApplicationTarifNormal(
        [FromRoute()] ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticlePeriodeApplicationTarifNormal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ArticlePeriodeApplicationTarifNormals
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ArticlePeriodeApplicationTarifNormal>>
    > ArticlePeriodeApplicationTarifNormals(
        [FromQuery()] ArticlePeriodeApplicationTarifNormalFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePeriodeApplicationTarifNormals(filter));
    }

    /// <summary>
    /// Meta data about ArticlePeriodeApplicationTarifNormal records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticlePeriodeApplicationTarifNormalsMeta(
        [FromQuery()] ArticlePeriodeApplicationTarifNormalFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePeriodeApplicationTarifNormalsMeta(filter));
    }

    /// <summary>
    /// Get one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePeriodeApplicationTarifNormal>
    > ArticlePeriodeApplicationTarifNormal(
        [FromRoute()] ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticlePeriodeApplicationTarifNormal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ArticlePeriodeApplicationTarifNormal
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticlePeriodeApplicationTarifNormal(
        [FromRoute()] ArticlePeriodeApplicationTarifNormalWhereUniqueInput uniqueId,
        [FromQuery()]
            ArticlePeriodeApplicationTarifNormalUpdateInput articlePeriodeApplicationTarifNormalUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticlePeriodeApplicationTarifNormal(
                uniqueId,
                articlePeriodeApplicationTarifNormalUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
