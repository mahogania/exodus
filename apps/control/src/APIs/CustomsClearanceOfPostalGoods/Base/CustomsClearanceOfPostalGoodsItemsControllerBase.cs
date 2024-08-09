using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CustomsClearanceOfPostalGoodsItemsControllerBase : ControllerBase
{
    protected readonly ICustomsClearanceOfPostalGoodsItemsService _service;

    public CustomsClearanceOfPostalGoodsItemsControllerBase(
        ICustomsClearanceOfPostalGoodsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CustomsClearanceOfPostalGoods>
    > CreateCustomsClearanceOfPostalGoods(CustomsClearanceOfPostalGoodsCreateInput input)
    {
        var customsClearanceOfPostalGoods = await _service.CreateCustomsClearanceOfPostalGoods(
            input
        );

        return CreatedAtAction(
            nameof(CustomsClearanceOfPostalGoods),
            new { id = customsClearanceOfPostalGoods.Id },
            customsClearanceOfPostalGoods
        );
    }

    /// <summary>
    /// Delete one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCustomsClearanceOfPostalGoods(
        [FromRoute()] CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCustomsClearanceOfPostalGoods(uniqueId);
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
    public async Task<
        ActionResult<List<CustomsClearanceOfPostalGoods>>
    > CustomsClearanceOfPostalGoodsItems(
        [FromQuery()] CustomsClearanceOfPostalGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsClearanceOfPostalGoodsItems(filter));
    }

    /// <summary>
    /// Meta data about CUSTOMS CLEARANCE OF POSTAL GOODS records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CustomsClearanceOfPostalGoodsItemsMeta(
        [FromQuery()] CustomsClearanceOfPostalGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsClearanceOfPostalGoodsItemsMeta(filter));
    }

    /// <summary>
    /// Get one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CustomsClearanceOfPostalGoods>> CustomsClearanceOfPostalGoods(
        [FromRoute()] CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CustomsClearanceOfPostalGoods(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCustomsClearanceOfPostalGoods(
        [FromRoute()] CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId,
        [FromQuery()]
            CustomsClearanceOfPostalGoodsUpdateInput customsClearanceOfPostalGoodsUpdateDto
    )
    {
        try
        {
            await _service.UpdateCustomsClearanceOfPostalGoods(
                uniqueId,
                customsClearanceOfPostalGoodsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
