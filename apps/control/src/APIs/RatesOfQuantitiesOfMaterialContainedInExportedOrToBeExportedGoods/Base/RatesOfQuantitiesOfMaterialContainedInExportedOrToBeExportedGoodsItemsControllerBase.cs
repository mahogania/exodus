using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsControllerBase
    : ControllerBase
{
    protected readonly IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService _service;

    public RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsControllerBase(
        IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods>
    > CreateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsCreateInput input
    )
    {
        var ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods =
            await _service.CreateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
                input
            );

        return CreatedAtAction(
            nameof(RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods),
            new { id = ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods.Id },
            ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods
        );
    }

    /// <summary>
    /// Delete one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        [FromRoute()]
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
                uniqueId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODSItems
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods>>
    > RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems(
        [FromQuery()]
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsFindManyArgs filter
    )
    {
        return Ok(
            await _service.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems(
                filter
            )
        );
    }

    /// <summary>
    /// Meta data about RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsMeta(
        [FromQuery()]
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsFindManyArgs filter
    )
    {
        return Ok(
            await _service.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItemsMeta(
                filter
            )
        );
    }

    /// <summary>
    /// Get one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods>
    > RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        [FromRoute()]
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
                uniqueId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one RATES OF QUANTITIES OF MATERIAL CONTAINED IN EXPORTED OR TO BE EXPORTED GOODS
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
        [FromRoute()]
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereUniqueInput uniqueId,
        [FromQuery()]
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsUpdateInput ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsUpdateDto
    )
    {
        try
        {
            await _service.UpdateRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods(
                uniqueId,
                ratesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
