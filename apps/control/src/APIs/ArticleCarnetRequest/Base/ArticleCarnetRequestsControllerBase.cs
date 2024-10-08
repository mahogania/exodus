using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticleCarnetRequestsControllerBase : ControllerBase
{
    protected readonly IArticleCarnetRequestsService _service;

    public ArticleCarnetRequestsControllerBase(IArticleCarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Article Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleCarnetRequest>> CreateArticleCarnetRequest(
        ArticleCarnetRequestCreateInput input
    )
    {
        var articleCarnetRequest = await _service.CreateArticleCarnetRequest(input);

        return CreatedAtAction(
            nameof(ArticleCarnetRequest),
            new { id = articleCarnetRequest.Id },
            articleCarnetRequest
        );
    }

    /// <summary>
    /// Delete one Article Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticleCarnetRequest(
        [FromRoute()] ArticleCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticleCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Article Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ArticleCarnetRequest>>> ArticleCarnetRequests(
        [FromQuery()] ArticleCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleCarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Article Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticleCarnetRequestsMeta(
        [FromQuery()] ArticleCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ArticleCarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Article Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ArticleCarnetRequest>> ArticleCarnetRequest(
        [FromRoute()] ArticleCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticleCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Article Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticleCarnetRequest(
        [FromRoute()] ArticleCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ArticleCarnetRequestUpdateInput articleCarnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticleCarnetRequest(uniqueId, articleCarnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Article Carnet Control record for Article Carnet Request
    /// </summary>
    [HttpGet("{Id}/articleCarnetControls")]
    public async Task<ActionResult<List<ArticleCarnetControl>>> GetArticleCarnetControl(
        [FromRoute()] ArticleCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var articleCarnetControl = await _service.GetArticleCarnetControl(uniqueId);
        return Ok(articleCarnetControl);
    }

    /// <summary>
    /// Get a Common Carnet Request record for Article Carnet Request
    /// </summary>
    [HttpGet("{Id}/commonCarnetRequests")]
    public async Task<ActionResult<List<CommonCarnetRequest>>> GetCommonCarnetRequest(
        [FromRoute()] ArticleCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var commonCarnetRequest = await _service.GetCommonCarnetRequest(uniqueId);
        return Ok(commonCarnetRequest);
    }
}
