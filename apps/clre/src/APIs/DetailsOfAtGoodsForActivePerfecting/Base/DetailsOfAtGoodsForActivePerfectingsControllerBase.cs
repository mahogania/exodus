using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailsOfAtGoodsForActivePerfectingsControllerBase : ControllerBase
{
    protected readonly IDetailsOfAtGoodsForActivePerfectingsService _service;

    public DetailsOfAtGoodsForActivePerfectingsControllerBase(
        IDetailsOfAtGoodsForActivePerfectingsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfAtGoodsForActivePerfecting>
    > CreateDetailsOfAtGoodsForActivePerfecting(
        DetailsOfAtGoodsForActivePerfectingCreateInput input
    )
    {
        var detailsOfAtGoodsForActivePerfecting =
            await _service.CreateDetailsOfAtGoodsForActivePerfecting(input);

        return CreatedAtAction(
            nameof(DetailsOfAtGoodsForActivePerfecting),
            new { id = detailsOfAtGoodsForActivePerfecting.Id },
            detailsOfAtGoodsForActivePerfecting
        );
    }

    /// <summary>
    /// Delete one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailsOfAtGoodsForActivePerfecting(
        [FromRoute()] DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailsOfAtGoodsForActivePerfecting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DETAILS OF AT GOODS FOR ACTIVE PERFECTINGS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DetailsOfAtGoodsForActivePerfecting>>
    > DetailsOfAtGoodsForActivePerfectings(
        [FromQuery()] DetailsOfAtGoodsForActivePerfectingFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfAtGoodsForActivePerfectings(filter));
    }

    /// <summary>
    /// Meta data about DETAILS OF AT GOODS FOR ACTIVE PERFECTING records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailsOfAtGoodsForActivePerfectingsMeta(
        [FromQuery()] DetailsOfAtGoodsForActivePerfectingFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfAtGoodsForActivePerfectingsMeta(filter));
    }

    /// <summary>
    /// Get one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfAtGoodsForActivePerfecting>
    > DetailsOfAtGoodsForActivePerfecting(
        [FromRoute()] DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailsOfAtGoodsForActivePerfecting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DETAILS OF AT GOODS FOR ACTIVE PERFECTING
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailsOfAtGoodsForActivePerfecting(
        [FromRoute()] DetailsOfAtGoodsForActivePerfectingWhereUniqueInput uniqueId,
        [FromQuery()]
            DetailsOfAtGoodsForActivePerfectingUpdateInput detailsOfAtGoodsForActivePerfectingUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailsOfAtGoodsForActivePerfecting(
                uniqueId,
                detailsOfAtGoodsForActivePerfectingUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
