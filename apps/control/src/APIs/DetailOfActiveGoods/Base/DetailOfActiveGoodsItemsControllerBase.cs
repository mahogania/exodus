using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailOfActiveGoodsItemsControllerBase : ControllerBase
{
    protected readonly IDetailOfActiveGoodsItemsService _service;

    public DetailOfActiveGoodsItemsControllerBase(IDetailOfActiveGoodsItemsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Detail of Active Goods
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DetailOfActiveGoods>> CreateDetailOfActiveGoods(
        DetailOfActiveGoodsCreateInput input
    )
    {
        var detailOfActiveGoods = await _service.CreateDetailOfActiveGoods(input);

        return CreatedAtAction(
            nameof(DetailOfActiveGoods),
            new { id = detailOfActiveGoods.Id },
            detailOfActiveGoods
        );
    }

    /// <summary>
    /// Delete one Detail of Active Goods
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailOfActiveGoods(
        [FromRoute()] DetailOfActiveGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailOfActiveGoods(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Details of Active Goods
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<DetailOfActiveGoods>>> DetailOfActiveGoodsItems(
        [FromQuery()] DetailOfActiveGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfActiveGoodsItems(filter));
    }

    /// <summary>
    /// Meta data about Detail of Active Goods records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailOfActiveGoodsItemsMeta(
        [FromQuery()] DetailOfActiveGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfActiveGoodsItemsMeta(filter));
    }

    /// <summary>
    /// Get one Detail of Active Goods
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DetailOfActiveGoods>> DetailOfActiveGoods(
        [FromRoute()] DetailOfActiveGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailOfActiveGoods(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Detail of Active Goods
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailOfActiveGoods(
        [FromRoute()] DetailOfActiveGoodsWhereUniqueInput uniqueId,
        [FromQuery()] DetailOfActiveGoodsUpdateInput detailOfActiveGoodsUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailOfActiveGoods(uniqueId, detailOfActiveGoodsUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Active Goods Request record for Details of Active Goods
    /// </summary>
    [HttpGet("{Id}/commonActiveGoodsRequests")]
    public async Task<ActionResult<List<CommonActiveGoodsRequest>>> GetCommonActiveGoodsRequest(
        [FromRoute()] DetailOfActiveGoodsWhereUniqueInput uniqueId
    )
    {
        var commonActiveGoodsRequest = await _service.GetCommonActiveGoodsRequest(uniqueId);
        return Ok(commonActiveGoodsRequest);
    }
}
