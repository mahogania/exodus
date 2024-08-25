using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticlePeriodeApplicationTarifSpecialsControllerBase : ControllerBase
{
    protected readonly IArticlePeriodeApplicationTarifSpecialsService _service;

    public ArticlePeriodeApplicationTarifSpecialsControllerBase(
        IArticlePeriodeApplicationTarifSpecialsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePeriodeApplicationTarifSpecial>
    > CreateArticlePeriodeApplicationTarifSpecial(
        ArticlePeriodeApplicationTarifSpecialCreateInput input
    )
    {
        var articlePeriodeApplicationTarifSpecial =
            await _service.CreateArticlePeriodeApplicationTarifSpecial(input);

        return CreatedAtAction(
            nameof(ArticlePeriodeApplicationTarifSpecial),
            new { id = articlePeriodeApplicationTarifSpecial.Id },
            articlePeriodeApplicationTarifSpecial
        );
    }

    /// <summary>
    /// Delete one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticlePeriodeApplicationTarifSpecial(
        [FromRoute()] ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticlePeriodeApplicationTarifSpecial(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ArticlePeriodeApplicationTarifSpecials
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ArticlePeriodeApplicationTarifSpecial>>
    > ArticlePeriodeApplicationTarifSpecials(
        [FromQuery()] ArticlePeriodeApplicationTarifSpecialFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePeriodeApplicationTarifSpecials(filter));
    }

    /// <summary>
    /// Meta data about ArticlePeriodeApplicationTarifSpecial records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticlePeriodeApplicationTarifSpecialsMeta(
        [FromQuery()] ArticlePeriodeApplicationTarifSpecialFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlePeriodeApplicationTarifSpecialsMeta(filter));
    }

    /// <summary>
    /// Get one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlePeriodeApplicationTarifSpecial>
    > ArticlePeriodeApplicationTarifSpecial(
        [FromRoute()] ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticlePeriodeApplicationTarifSpecial(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ArticlePeriodeApplicationTarifSpecial
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticlePeriodeApplicationTarifSpecial(
        [FromRoute()] ArticlePeriodeApplicationTarifSpecialWhereUniqueInput uniqueId,
        [FromQuery()]
            ArticlePeriodeApplicationTarifSpecialUpdateInput articlePeriodeApplicationTarifSpecialUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticlePeriodeApplicationTarifSpecial(
                uniqueId,
                articlePeriodeApplicationTarifSpecialUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
