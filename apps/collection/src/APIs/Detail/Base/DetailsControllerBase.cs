using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailsControllerBase : ControllerBase
{
    protected readonly IDetailsService _service;

    public DetailsControllerBase(IDetailsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one DETAIL
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Detail>> CreateDetail(DetailCreateInput input)
    {
        var detail = await _service.CreateDetail(input);

        return CreatedAtAction(nameof(Detail), new { id = detail.Id }, detail);
    }

    /// <summary>
    /// Delete one DETAIL
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetail([FromRoute()] DetailWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteDetail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DETAILS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Detail>>> Details([FromQuery()] DetailFindManyArgs filter)
    {
        return Ok(await _service.Details(filter));
    }

    /// <summary>
    /// Meta data about DETAIL records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailsMeta(
        [FromQuery()] DetailFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsMeta(filter));
    }

    /// <summary>
    /// Get one DETAIL
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Detail>> Detail([FromRoute()] DetailWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Detail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DETAIL
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetail(
        [FromRoute()] DetailWhereUniqueInput uniqueId,
        [FromQuery()] DetailUpdateInput detailUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetail(uniqueId, detailUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
