using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class GoodsImportedForPerfectingsControllerBase : ControllerBase
{
    protected readonly IGoodsImportedForPerfectingsService _service;

    public GoodsImportedForPerfectingsControllerBase(IGoodsImportedForPerfectingsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<GoodsImportedForPerfecting>> CreateGoodsImportedForPerfecting(
        GoodsImportedForPerfectingCreateInput input
    )
    {
        var goodsImportedForPerfecting = await _service.CreateGoodsImportedForPerfecting(input);

        return CreatedAtAction(
            nameof(GoodsImportedForPerfecting),
            new { id = goodsImportedForPerfecting.Id },
            goodsImportedForPerfecting
        );
    }

    /// <summary>
    /// Delete one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteGoodsImportedForPerfecting(
        [FromRoute()] GoodsImportedForPerfectingWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteGoodsImportedForPerfecting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many GOODS IMPORTED FOR PERFECTINGS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<GoodsImportedForPerfecting>>> GoodsImportedForPerfectings(
        [FromQuery()] GoodsImportedForPerfectingFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsImportedForPerfectings(filter));
    }

    /// <summary>
    /// Meta data about GOODS IMPORTED FOR PERFECTING records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> GoodsImportedForPerfectingsMeta(
        [FromQuery()] GoodsImportedForPerfectingFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsImportedForPerfectingsMeta(filter));
    }

    /// <summary>
    /// Get one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<GoodsImportedForPerfecting>> GoodsImportedForPerfecting(
        [FromRoute()] GoodsImportedForPerfectingWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.GoodsImportedForPerfecting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one GOODS IMPORTED FOR PERFECTING
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGoodsImportedForPerfecting(
        [FromRoute()] GoodsImportedForPerfectingWhereUniqueInput uniqueId,
        [FromQuery()] GoodsImportedForPerfectingUpdateInput goodsImportedForPerfectingUpdateDto
    )
    {
        try
        {
            await _service.UpdateGoodsImportedForPerfecting(
                uniqueId,
                goodsImportedForPerfectingUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
