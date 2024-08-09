using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class OthersItemsControllerBase : ControllerBase
{
    protected readonly IOthersItemsService _service;

    public OthersItemsControllerBase(IOthersItemsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one OTHERS
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Others>> CreateOthers(OthersCreateInput input)
    {
        var others = await _service.CreateOthers(input);

        return CreatedAtAction(nameof(Others), new { id = others.Id }, others);
    }

    /// <summary>
    /// Delete one OTHERS
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteOthers([FromRoute()] OthersWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteOthers(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many OTHERSItems
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Others>>> OthersItems(
        [FromQuery()] OthersFindManyArgs filter
    )
    {
        return Ok(await _service.OthersItems(filter));
    }

    /// <summary>
    /// Meta data about OTHERS records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> OthersItemsMeta(
        [FromQuery()] OthersFindManyArgs filter
    )
    {
        return Ok(await _service.OthersItemsMeta(filter));
    }

    /// <summary>
    /// Get one OTHERS
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Others>> Others([FromRoute()] OthersWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Others(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one OTHERS
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateOthers(
        [FromRoute()] OthersWhereUniqueInput uniqueId,
        [FromQuery()] OthersUpdateInput othersUpdateDto
    )
    {
        try
        {
            await _service.UpdateOthers(uniqueId, othersUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
