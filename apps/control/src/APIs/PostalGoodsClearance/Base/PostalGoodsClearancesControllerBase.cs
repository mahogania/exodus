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

    /// <summary>
    /// Connect multiple Postal Goods Clearance Details records to Postal Goods Clearance
    /// </summary>
    [HttpPost("{Id}/postalGoodsClearanceDetails")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectPostalGoodsClearanceDetails(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId,
        [FromQuery()] PostalGoodsClearanceDetailWhereUniqueInput[] postalGoodsClearanceDetailsId
    )
    {
        try
        {
            await _service.ConnectPostalGoodsClearanceDetails(
                uniqueId,
                postalGoodsClearanceDetailsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Postal Goods Clearance Details records from Postal Goods Clearance
    /// </summary>
    [HttpDelete("{Id}/postalGoodsClearanceDetails")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectPostalGoodsClearanceDetails(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId,
        [FromBody()] PostalGoodsClearanceDetailWhereUniqueInput[] postalGoodsClearanceDetailsId
    )
    {
        try
        {
            await _service.DisconnectPostalGoodsClearanceDetails(
                uniqueId,
                postalGoodsClearanceDetailsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Postal Goods Clearance Details records for Postal Goods Clearance
    /// </summary>
    [HttpGet("{Id}/postalGoodsClearanceDetails")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<PostalGoodsClearanceDetail>>
    > FindPostalGoodsClearanceDetails(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId,
        [FromQuery()] PostalGoodsClearanceDetailFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindPostalGoodsClearanceDetails(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Postal Goods Clearance Details records for Postal Goods Clearance
    /// </summary>
    [HttpPatch("{Id}/postalGoodsClearanceDetails")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePostalGoodsClearanceDetails(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId,
        [FromBody()] PostalGoodsClearanceDetailWhereUniqueInput[] postalGoodsClearanceDetailsId
    )
    {
        try
        {
            await _service.UpdatePostalGoodsClearanceDetails(
                uniqueId,
                postalGoodsClearanceDetailsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Procedure record for Postal Goods Clearance
    /// </summary>
    [HttpGet("{Id}/procedures")]
    public async Task<ActionResult<List<Procedure>>> GetProcedure(
        [FromRoute()] PostalGoodsClearanceWhereUniqueInput uniqueId
    )
    {
        var procedure = await _service.GetProcedure(uniqueId);
        return Ok(procedure);
    }
}
