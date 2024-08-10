using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class GoodsAndWithReImportationInStatesControllerBase : ControllerBase
{
    protected readonly IGoodsAndWithReImportationInStatesService _service;

    public GoodsAndWithReImportationInStatesControllerBase(
        IGoodsAndWithReImportationInStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<GoodsAndWithReImportationInState>
    > CreateGoodsAndWithReImportationInState(GoodsAndWithReImportationInStateCreateInput input)
    {
        var goodsAndWithReImportationInState =
            await _service.CreateGoodsAndWithReImportationInState(input);

        return CreatedAtAction(
            nameof(GoodsAndWithReImportationInState),
            new { id = goodsAndWithReImportationInState.Id },
            goodsAndWithReImportationInState
        );
    }

    /// <summary>
    ///     Delete one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteGoodsAndWithReImportationInState(
        [FromRoute] GoodsAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteGoodsAndWithReImportationInState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many GOODS AND WITH RE-IMPORTATION IN STATES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GoodsAndWithReImportationInState>>
    > GoodsAndWithReImportationInStates(
        [FromQuery] GoodsAndWithReImportationInStateFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsAndWithReImportationInStates(filter));
    }

    /// <summary>
    ///     Meta data about GOODS AND WITH RE-IMPORTATION IN STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> GoodsAndWithReImportationInStatesMeta(
        [FromQuery] GoodsAndWithReImportationInStateFindManyArgs filter
    )
    {
        return Ok(await _service.GoodsAndWithReImportationInStatesMeta(filter));
    }

    /// <summary>
    ///     Get one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<GoodsAndWithReImportationInState>
    > GoodsAndWithReImportationInState(
        [FromRoute] GoodsAndWithReImportationInStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.GoodsAndWithReImportationInState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGoodsAndWithReImportationInState(
        [FromRoute] GoodsAndWithReImportationInStateWhereUniqueInput uniqueId,
        [FromQuery] GoodsAndWithReImportationInStateUpdateInput goodsAndWithReImportationInStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateGoodsAndWithReImportationInState(
                uniqueId,
                goodsAndWithReImportationInStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
