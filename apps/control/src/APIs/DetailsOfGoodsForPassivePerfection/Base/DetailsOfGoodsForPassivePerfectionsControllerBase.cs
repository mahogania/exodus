using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailsOfGoodsForPassivePerfectionsControllerBase : ControllerBase
{
    protected readonly IDetailsOfGoodsForPassivePerfectionsService _service;

    public DetailsOfGoodsForPassivePerfectionsControllerBase(
        IDetailsOfGoodsForPassivePerfectionsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfGoodsForPassivePerfection>
    > CreateDetailsOfGoodsForPassivePerfection(DetailsOfGoodsForPassivePerfectionCreateInput input)
    {
        var detailsOfGoodsForPassivePerfection =
            await _service.CreateDetailsOfGoodsForPassivePerfection(input);

        return CreatedAtAction(
            nameof(DetailsOfGoodsForPassivePerfection),
            new { id = detailsOfGoodsForPassivePerfection.Id },
            detailsOfGoodsForPassivePerfection
        );
    }

    /// <summary>
    /// Delete one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailsOfGoodsForPassivePerfection(
        [FromRoute()] DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailsOfGoodsForPassivePerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DETAILS OF GOODS FOR PASSIVE PERFECTIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DetailsOfGoodsForPassivePerfection>>
    > DetailsOfGoodsForPassivePerfections(
        [FromQuery()] DetailsOfGoodsForPassivePerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfGoodsForPassivePerfections(filter));
    }

    /// <summary>
    /// Meta data about DETAILS OF GOODS FOR PASSIVE PERFECTION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailsOfGoodsForPassivePerfectionsMeta(
        [FromQuery()] DetailsOfGoodsForPassivePerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfGoodsForPassivePerfectionsMeta(filter));
    }

    /// <summary>
    /// Get one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfGoodsForPassivePerfection>
    > DetailsOfGoodsForPassivePerfection(
        [FromRoute()] DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailsOfGoodsForPassivePerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DETAILS OF GOODS FOR PASSIVE PERFECTION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailsOfGoodsForPassivePerfection(
        [FromRoute()] DetailsOfGoodsForPassivePerfectionWhereUniqueInput uniqueId,
        [FromQuery()]
            DetailsOfGoodsForPassivePerfectionUpdateInput detailsOfGoodsForPassivePerfectionUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailsOfGoodsForPassivePerfection(
                uniqueId,
                detailsOfGoodsForPassivePerfectionUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
