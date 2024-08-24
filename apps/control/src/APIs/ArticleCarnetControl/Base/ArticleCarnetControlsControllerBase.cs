using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticleCarnetControlsControllerBase : ControllerBase
{
    protected readonly IArticleCarnetControlsService _service;

    public ArticleCarnetControlsControllerBase(IArticleCarnetControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Article Carnet Control
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleCarnetControl>> CreateArticleCarnetControl(
        ArticleCarnetControlCreateInput input
    )
    {
        var articleCarnetControl = await _service.CreateArticleCarnetControl(input);

        return CreatedAtAction(
            nameof(ArticleCarnetControl),
            new { id = articleCarnetControl.Id },
            articleCarnetControl
        );
    }

    /// <summary>
    /// Delete one Article Carnet Control
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticleCarnetControl(
        [FromRoute()] ArticleCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticleCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Article Carnet Controls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleCarnetControl>>> ArticleCarnetControls(
        [FromQuery()] ArticleCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleCarnetControls(filter));
    }

    /// <summary>
    /// Meta data about Article Carnet Control records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticleCarnetControlsMeta(
        [FromQuery()] ArticleCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleCarnetControlsMeta(filter));
    }

    /// <summary>
    /// Get one Article Carnet Control
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleCarnetControl>> ArticleCarnetControl(
        [FromRoute()] ArticleCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticleCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Article Carnet Control
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleCarnetControl(
        [FromRoute()] ArticleCarnetControlWhereUniqueInput uniqueId,
        [FromQuery()] ArticleCarnetControlUpdateInput articleCarnetControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticleCarnetControl(uniqueId, articleCarnetControlUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
