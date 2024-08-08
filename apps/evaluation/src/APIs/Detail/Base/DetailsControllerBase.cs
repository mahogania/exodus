using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

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
    /// Create one Detail
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Detail>> CreateDetail(DetailCreateInput input)
    {
        var detail = await _service.CreateDetail(input);

        return CreatedAtAction(nameof(Detail), new { id = detail.Id }, detail);
    }

    /// <summary>
    /// Delete one Detail
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
    /// Find many Details
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Detail>>> Details([FromQuery()] DetailFindManyArgs filter)
    {
        return Ok(await _service.Details(filter));
    }

    /// <summary>
    /// Meta data about Detail records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailsMeta(
        [FromQuery()] DetailFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsMeta(filter));
    }

    /// <summary>
    /// Get one Detail
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
    /// Update one Detail
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
