using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PostalParcelSimplifiedClearancesControllerBase : ControllerBase
{
    protected readonly IPostalParcelSimplifiedClearancesService _service;

    public PostalParcelSimplifiedClearancesControllerBase(
        IPostalParcelSimplifiedClearancesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Postal Parcel Simplified Clearance
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<PostalParcelSimplifiedClearance>
    > CreatePostalParcelSimplifiedClearance(PostalParcelSimplifiedClearanceCreateInput input)
    {
        var postalParcelSimplifiedClearance = await _service.CreatePostalParcelSimplifiedClearance(
            input
        );

        return CreatedAtAction(
            nameof(PostalParcelSimplifiedClearance),
            new { id = postalParcelSimplifiedClearance.Id },
            postalParcelSimplifiedClearance
        );
    }

    /// <summary>
    /// Delete one Postal Parcel Simplified Clearance
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePostalParcelSimplifiedClearance(
        [FromRoute()] PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePostalParcelSimplifiedClearance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELSItems
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<PostalParcelSimplifiedClearance>>
    > PostalParcelSimplifiedClearances(
        [FromQuery()] PostalParcelSimplifiedClearanceFindManyArgs filter
    )
    {
        return Ok(await _service.PostalParcelSimplifiedClearances(filter));
    }

    /// <summary>
    /// Meta data about Postal Parcel Simplified Clearance records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PostalParcelSimplifiedClearancesMeta(
        [FromQuery()] PostalParcelSimplifiedClearanceFindManyArgs filter
    )
    {
        return Ok(await _service.PostalParcelSimplifiedClearancesMeta(filter));
    }

    /// <summary>
    /// Get one Postal Parcel Simplified Clearance
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<PostalParcelSimplifiedClearance>
    > PostalParcelSimplifiedClearance(
        [FromRoute()] PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PostalParcelSimplifiedClearance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Postal Parcel Simplified Clearance
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePostalParcelSimplifiedClearance(
        [FromRoute()] PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId,
        [FromQuery()]
            PostalParcelSimplifiedClearanceUpdateInput postalParcelSimplifiedClearanceUpdateDto
    )
    {
        try
        {
            await _service.UpdatePostalParcelSimplifiedClearance(
                uniqueId,
                postalParcelSimplifiedClearanceUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Procedure record for Postal Parcel Simplified Clearance
    /// </summary>
    [HttpGet("{Id}/procedures")]
    public async Task<ActionResult<List<Procedure>>> GetProcedure(
        [FromRoute()] PostalParcelSimplifiedClearanceWhereUniqueInput uniqueId
    )
    {
        var procedure = await _service.GetProcedure(uniqueId);
        return Ok(procedure);
    }
}
