using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class ExportedAndForImprovementGoodsItemsControllerBase : ControllerBase
{
    protected readonly IExportedAndForImprovementGoodsItemsService _service;

    public ExportedAndForImprovementGoodsItemsControllerBase(
        IExportedAndForImprovementGoodsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ExportedAndForImprovementGoods>
    > CreateExportedAndForImprovementGoods(ExportedAndForImprovementGoodsCreateInput input)
    {
        var exportedAndForImprovementGoods = await _service.CreateExportedAndForImprovementGoods(
            input
        );

        return CreatedAtAction(
            nameof(ExportedAndForImprovementGoods),
            new { id = exportedAndForImprovementGoods.Id },
            exportedAndForImprovementGoods
        );
    }

    /// <summary>
    ///     Delete one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExportedAndForImprovementGoods(
        [FromRoute] ExportedAndForImprovementGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteExportedAndForImprovementGoods(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many EXPORTED AND FOR IMPROVEMENT GOODSItems
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ExportedAndForImprovementGoods>>
    > ExportedAndForImprovementGoodsItems(
        [FromQuery] ExportedAndForImprovementGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.ExportedAndForImprovementGoodsItems(filter));
    }

    /// <summary>
    ///     Meta data about EXPORTED AND FOR IMPROVEMENT GOODS records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExportedAndForImprovementGoodsItemsMeta(
        [FromQuery] ExportedAndForImprovementGoodsFindManyArgs filter
    )
    {
        return Ok(await _service.ExportedAndForImprovementGoodsItemsMeta(filter));
    }

    /// <summary>
    ///     Get one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExportedAndForImprovementGoods>> ExportedAndForImprovementGoods(
        [FromRoute] ExportedAndForImprovementGoodsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ExportedAndForImprovementGoods(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one EXPORTED AND FOR IMPROVEMENT GOODS
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExportedAndForImprovementGoods(
        [FromRoute] ExportedAndForImprovementGoodsWhereUniqueInput uniqueId,
        [FromQuery] ExportedAndForImprovementGoodsUpdateInput exportedAndForImprovementGoodsUpdateDto
    )
    {
        try
        {
            await _service.UpdateExportedAndForImprovementGoods(
                uniqueId,
                exportedAndForImprovementGoodsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
