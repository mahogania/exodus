using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RequestForTirCarnetOfTheArticlesControllerBase : ControllerBase
{
    protected readonly IRequestForTirCarnetOfTheArticlesService _service;

    public RequestForTirCarnetOfTheArticlesControllerBase(
        IRequestForTirCarnetOfTheArticlesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RequestForTirCarnetOfTheArticle>
    > CreateRequestForTirCarnetOfTheArticle(RequestForTirCarnetOfTheArticleCreateInput input)
    {
        var requestForTirCarnetOfTheArticle = await _service.CreateRequestForTirCarnetOfTheArticle(
            input
        );

        return CreatedAtAction(
            nameof(RequestForTirCarnetOfTheArticle),
            new { id = requestForTirCarnetOfTheArticle.Id },
            requestForTirCarnetOfTheArticle
        );
    }

    /// <summary>
    /// Delete one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRequestForTirCarnetOfTheArticle(
        [FromRoute()] RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRequestForTirCarnetOfTheArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many REQUEST FOR TIR CARNET OF THE ARTICLES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<RequestForTirCarnetOfTheArticle>>
    > RequestForTirCarnetOfTheArticles(
        [FromQuery()] RequestForTirCarnetOfTheArticleFindManyArgs filter
    )
    {
        return Ok(await _service.RequestForTirCarnetOfTheArticles(filter));
    }

    /// <summary>
    /// Meta data about REQUEST FOR TIR CARNET OF THE ARTICLE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RequestForTirCarnetOfTheArticlesMeta(
        [FromQuery()] RequestForTirCarnetOfTheArticleFindManyArgs filter
    )
    {
        return Ok(await _service.RequestForTirCarnetOfTheArticlesMeta(filter));
    }

    /// <summary>
    /// Get one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RequestForTirCarnetOfTheArticle>
    > RequestForTirCarnetOfTheArticle(
        [FromRoute()] RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RequestForTirCarnetOfTheArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one REQUEST FOR TIR CARNET OF THE ARTICLE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRequestForTirCarnetOfTheArticle(
        [FromRoute()] RequestForTirCarnetOfTheArticleWhereUniqueInput uniqueId,
        [FromQuery()]
            RequestForTirCarnetOfTheArticleUpdateInput requestForTirCarnetOfTheArticleUpdateDto
    )
    {
        try
        {
            await _service.UpdateRequestForTirCarnetOfTheArticle(
                uniqueId,
                requestForTirCarnetOfTheArticleUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
