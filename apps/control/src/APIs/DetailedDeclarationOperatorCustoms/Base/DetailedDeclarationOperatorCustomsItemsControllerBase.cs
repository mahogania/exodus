using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class DetailedDeclarationOperatorCustomsItemsControllerBase : ControllerBase
{
    protected readonly IDetailedDeclarationOperatorCustomsItemsService _service;

    public DetailedDeclarationOperatorCustomsItemsControllerBase(
        IDetailedDeclarationOperatorCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailedDeclarationOperatorCustoms>
    > CreateDetailedDeclarationOperatorCustoms(DetailedDeclarationOperatorCustomsCreateInput input)
    {
        var detailedDeclarationOperatorCustoms =
            await _service.CreateDetailedDeclarationOperatorCustoms(input);

        return CreatedAtAction(
            nameof(DetailedDeclarationOperatorCustoms),
            new { id = detailedDeclarationOperatorCustoms.Id },
            detailedDeclarationOperatorCustoms
        );
    }

    /// <summary>
    ///     Delete one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailedDeclarationOperatorCustoms(
        [FromRoute] DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailedDeclarationOperatorCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many DETAILED DECLARATION OPERATOR (CUSTOMS)s
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DetailedDeclarationOperatorCustoms>>
    > DetailedDeclarationOperatorCustomsItems(
        [FromQuery] DetailedDeclarationOperatorCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.DetailedDeclarationOperatorCustomsItems(filter));
    }

    /// <summary>
    ///     Meta data about DETAILED DECLARATION OPERATOR (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailedDeclarationOperatorCustomsItemsMeta(
        [FromQuery] DetailedDeclarationOperatorCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.DetailedDeclarationOperatorCustomsItemsMeta(filter));
    }

    /// <summary>
    ///     Get one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailedDeclarationOperatorCustoms>
    > DetailedDeclarationOperatorCustoms(
        [FromRoute] DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailedDeclarationOperatorCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one DETAILED DECLARATION OPERATOR (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailedDeclarationOperatorCustoms(
        [FromRoute] DetailedDeclarationOperatorCustomsWhereUniqueInput uniqueId,
        [FromQuery] DetailedDeclarationOperatorCustomsUpdateInput detailedDeclarationOperatorCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailedDeclarationOperatorCustoms(
                uniqueId,
                detailedDeclarationOperatorCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
