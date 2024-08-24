using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PostalGoodsClearancesControllerBase : ControllerBase
{
    protected readonly IPostalGoodsClearancesService _service;

    public PostalGoodsClearancesControllerBase(IPostalGoodsClearancesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Postal Goods Clearance
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PostalGoodsClearance>> CreatePostalGoodsClearance(
        PostalGoodsClearanceCreateInput input
    )
    {
        var postalGoodsClearance = await _service.CreatePostalGoodsClearance(input);

        return CreatedAtAction(
            nameof(PostalGoodsClearance),
            new { id = postalGoodsClearance.Id },
            postalGoodsClearance
        );
    }

    /// <summary>
    /// Delete one Postal Goods Clearance
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePostalGoodsClearance(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePostalGoodsClearance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<PostalGoodsClearance>>> PostalGoodsClearances(
        [FromQuery()] PostalGoodsClearanceFindManyArgs filter
    )
    {
        return Ok(await _service.PostalGoodsClearances(filter));
    }

    /// <summary>
    /// Meta data about Postal Goods Clearance records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PostalGoodsClearancesMeta(
        [FromQuery()] PostalGoodsClearanceFindManyArgs filter
    )
    {
        return Ok(await _service.PostalGoodsClearancesMeta(filter));
    }

    /// <summary>
    /// Get one Postal Goods Clearance
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PostalGoodsClearance>> PostalGoodsClearance(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PostalGoodsClearance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Postal Goods Clearance
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePostalGoodsClearance(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId,
        [FromQuery()] PostalGoodsClearanceUpdateInput postalGoodsClearanceUpdateDto
    )
    {
        try
        {
            await _service.UpdatePostalGoodsClearance(uniqueId, postalGoodsClearanceUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
