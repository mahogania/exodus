using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PostalGoodsClearanceDetailsControllerBase : ControllerBase
{
    protected readonly IPostalGoodsClearanceDetailsService _service;

    public PostalGoodsClearanceDetailsControllerBase(IPostalGoodsClearanceDetailsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Postal Goods Clearance Detail
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PostalGoodsClearanceDetail>> CreatePostalGoodsClearanceDetail(
        PostalGoodsClearanceDetailCreateInput input
    )
    {
        var postalGoodsClearanceDetail = await _service.CreatePostalGoodsClearanceDetail(input);

        return CreatedAtAction(
            nameof(PostalGoodsClearanceDetail),
            new { id = postalGoodsClearanceDetail.Id },
            postalGoodsClearanceDetail
        );
    }

    /// <summary>
    /// Delete one Postal Goods Clearance Detail
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePostalGoodsClearanceDetail(
        [FromRoute()] PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePostalGoodsClearanceDetail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<PostalGoodsClearanceDetail>>> PostalGoodsClearanceDetails(
        [FromQuery()] PostalGoodsClearanceDetailFindManyArgs filter
    )
    {
        return Ok(await _service.PostalGoodsClearanceDetails(filter));
    }

    /// <summary>
    /// Meta data about Postal Goods Clearance Detail records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PostalGoodsClearanceDetailsMeta(
        [FromQuery()] PostalGoodsClearanceDetailFindManyArgs filter
    )
    {
        return Ok(await _service.PostalGoodsClearanceDetailsMeta(filter));
    }

    /// <summary>
    /// Get one Postal Goods Clearance Detail
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PostalGoodsClearanceDetail>> PostalGoodsClearanceDetail(
        [FromRoute()] PostalGoodsClearanceDetailWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PostalGoodsClearanceDetail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Postal Goods Clearance Detail
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePostalGoodsClearanceDetail(
        [FromRoute()] PostalGoodsClearanceDetailWhereUniqueInput uniqueId,
        [FromQuery()] PostalGoodsClearanceDetailUpdateInput postalGoodsClearanceDetailUpdateDto
    )
    {
        try
        {
            await _service.UpdatePostalGoodsClearanceDetail(
                uniqueId,
                postalGoodsClearanceDetailUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
