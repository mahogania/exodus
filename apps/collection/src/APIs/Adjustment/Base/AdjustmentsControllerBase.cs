using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class AdjustmentsControllerBase : ControllerBase
{
    protected readonly IAdjustmentsService _service;

    public AdjustmentsControllerBase(IAdjustmentsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one ADJUSTMENT
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Adjustment>> CreateAdjustment(AdjustmentCreateInput input)
    {
        var adjustment = await _service.CreateAdjustment(input);

        return CreatedAtAction(nameof(Adjustment), new { id = adjustment.Id }, adjustment);
    }

    /// <summary>
    ///     Delete one ADJUSTMENT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAdjustment(
        [FromRoute] AdjustmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAdjustment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many ADJUSTMENTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Adjustment>>> Adjustments(
        [FromQuery] AdjustmentFindManyArgs filter
    )
    {
        return Ok(await _service.Adjustments(filter));
    }

    /// <summary>
    ///     Meta data about ADJUSTMENT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AdjustmentsMeta(
        [FromQuery] AdjustmentFindManyArgs filter
    )
    {
        return Ok(await _service.AdjustmentsMeta(filter));
    }

    /// <summary>
    ///     Get one ADJUSTMENT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Adjustment>> Adjustment(
        [FromRoute] AdjustmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Adjustment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one ADJUSTMENT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAdjustment(
        [FromRoute] AdjustmentWhereUniqueInput uniqueId,
        [FromQuery] AdjustmentUpdateInput adjustmentUpdateDto
    )
    {
        try
        {
            await _service.UpdateAdjustment(uniqueId, adjustmentUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
