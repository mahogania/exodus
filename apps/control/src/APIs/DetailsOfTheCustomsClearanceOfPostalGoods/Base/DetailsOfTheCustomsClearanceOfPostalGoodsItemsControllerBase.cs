using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailsOfTheCustomsClearanceOfPostalGoodsItemsControllerBase : ControllerBase
{
    protected readonly IDetailsOfTheCustomsClearanceOfPostalGoodsItemsService _service;

    public DetailsOfTheCustomsClearanceOfPostalGoodsItemsControllerBase(
        IDetailsOfTheCustomsClearanceOfPostalGoodsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfTheCustomsClearanceOfPostalGoods>
    > CreateDetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsCreateInput input
    )
    {
        var detailsOfTheCustomsClearanceOfPostalGoods =
            await _service.CreateDetailsOfTheCustomsClearanceOfPostalGoods(input);

        return CreatedAtAction(
            nameof(DetailsOfTheCustomsClearanceOfPostalGoods),
            new { id = detailsOfTheCustomsClearanceOfPostalGoods.Id },
            detailsOfTheCustomsClearanceOfPostalGoods
        );
    }

    /// <summary>
    /// Delete one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailsOfTheCustomsClearanceOfPostalGoods(
        [FromRoute()] DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailsOfTheCustomsClearanceOfPostalGoods(uniqueId);
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
    public async Task<
        ActionResult<List<DetailsOfTheCustomsClearanceOfPostalGoods>>
    > DetailsOfTheCustomsClearanceOfPostalGoodsItems(
        [FromQuery()] DetailsOfTheCustomsClearanceOfPostalGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfTheCustomsClearanceOfPostalGoodsItems(filter));
    }

    /// <summary>
    /// Meta data about DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailsOfTheCustomsClearanceOfPostalGoodsItemsMeta(
        [FromQuery()] DetailsOfTheCustomsClearanceOfPostalGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfTheCustomsClearanceOfPostalGoodsItemsMeta(filter));
    }

    /// <summary>
    /// Get one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfTheCustomsClearanceOfPostalGoods>
    > DetailsOfTheCustomsClearanceOfPostalGoods(
        [FromRoute()] DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailsOfTheCustomsClearanceOfPostalGoods(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailsOfTheCustomsClearanceOfPostalGoods(
        [FromRoute()] DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId,
        [FromQuery()]
            DetailsOfTheCustomsClearanceOfPostalGoodsUpdateInput detailsOfTheCustomsClearanceOfPostalGoodsUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailsOfTheCustomsClearanceOfPostalGoods(
                uniqueId,
                detailsOfTheCustomsClearanceOfPostalGoodsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
