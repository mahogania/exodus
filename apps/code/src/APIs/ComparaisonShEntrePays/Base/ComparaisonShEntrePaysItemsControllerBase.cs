using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ComparaisonShEntrePaysItemsControllerBase : ControllerBase
{
    protected readonly IComparaisonShEntrePaysItemsService _service;

    public ComparaisonShEntrePaysItemsControllerBase(IComparaisonShEntrePaysItemsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ComparaisonShEntrePays
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ComparaisonShEntrePays>> CreateComparaisonShEntrePays(
        ComparaisonShEntrePaysCreateInput input
    )
    {
        var comparaisonShEntrePays = await _service.CreateComparaisonShEntrePays(input);

        return CreatedAtAction(
            nameof(ComparaisonShEntrePays),
            new { id = comparaisonShEntrePays.Id },
            comparaisonShEntrePays
        );
    }

    /// <summary>
    /// Delete one ComparaisonShEntrePays
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteComparaisonShEntrePays(
        [FromRoute()] ComparaisonShEntrePaysWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteComparaisonShEntrePays(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ComparaisonShEntrePaysItems
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ComparaisonShEntrePays>>> ComparaisonShEntrePaysItems(
        [FromQuery()] ComparaisonShEntrePaysFindManyArgs filter
    )
    {
        return Ok(await _service.ComparaisonShEntrePaysItems(filter));
    }

    /// <summary>
    /// Meta data about ComparaisonShEntrePays records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ComparaisonShEntrePaysItemsMeta(
        [FromQuery()] ComparaisonShEntrePaysFindManyArgs filter
    )
    {
        return Ok(await _service.ComparaisonShEntrePaysItemsMeta(filter));
    }

    /// <summary>
    /// Get one ComparaisonShEntrePays
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ComparaisonShEntrePays>> ComparaisonShEntrePays(
        [FromRoute()] ComparaisonShEntrePaysWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ComparaisonShEntrePays(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ComparaisonShEntrePays
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateComparaisonShEntrePays(
        [FromRoute()] ComparaisonShEntrePaysWhereUniqueInput uniqueId,
        [FromQuery()] ComparaisonShEntrePaysUpdateInput comparaisonShEntrePaysUpdateDto
    )
    {
        try
        {
            await _service.UpdateComparaisonShEntrePays(uniqueId, comparaisonShEntrePaysUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
