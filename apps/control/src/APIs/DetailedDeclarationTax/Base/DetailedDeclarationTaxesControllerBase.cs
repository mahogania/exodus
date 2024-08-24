using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailedDeclarationTaxesControllerBase : ControllerBase
{
    protected readonly IDetailedDeclarationTaxesService _service;

    public DetailedDeclarationTaxesControllerBase(IDetailedDeclarationTaxesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Detailed Declaration Tax
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DetailedDeclarationTax>> CreateDetailedDeclarationTax(
        DetailedDeclarationTaxCreateInput input
    )
    {
        var detailedDeclarationTax = await _service.CreateDetailedDeclarationTax(input);

        return CreatedAtAction(
            nameof(DetailedDeclarationTax),
            new { id = detailedDeclarationTax.Id },
            detailedDeclarationTax
        );
    }

    /// <summary>
    /// Delete one Detailed Declaration Tax
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailedDeclarationTax(
        [FromRoute()] DetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailedDeclarationTax(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many CUSTOMS DETAILED DECLARATION TAXES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<DetailedDeclarationTax>>> DetailedDeclarationTaxes(
        [FromQuery()] DetailedDeclarationTaxFindManyArgs filter
    )
    {
        return Ok(await _service.DetailedDeclarationTaxes(filter));
    }

    /// <summary>
    /// Meta data about Detailed Declaration Tax records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailedDeclarationTaxesMeta(
        [FromQuery()] DetailedDeclarationTaxFindManyArgs filter
    )
    {
        return Ok(await _service.DetailedDeclarationTaxesMeta(filter));
    }

    /// <summary>
    /// Get one Detailed Declaration Tax
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DetailedDeclarationTax>> DetailedDeclarationTax(
        [FromRoute()] DetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailedDeclarationTax(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Detailed Declaration Tax
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailedDeclarationTax(
        [FromRoute()] DetailedDeclarationTaxWhereUniqueInput uniqueId,
        [FromQuery()] DetailedDeclarationTaxUpdateInput detailedDeclarationTaxUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailedDeclarationTax(uniqueId, detailedDeclarationTaxUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Article record for Detailed Declaration Tax
    /// </summary>
    [HttpGet("{Id}/articles")]
    public async Task<ActionResult<List<Article>>> GetArticle(
        [FromRoute()] DetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        var article = await _service.GetArticle(uniqueId);
        return Ok(article);
    }
}
