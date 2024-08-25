using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesControllerBase
    : ControllerBase
{
    protected readonly IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService _service;

    public DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesControllerBase(
        IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState>
    > CreateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateCreateInput input
    )
    {
        var definitiveExportGoodsFollowedByAndWithReimportationInTheState =
            await _service.CreateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
                input
            );

        return CreatedAtAction(
            nameof(DefinitiveExportGoodsFollowedByAndWithReimportationInTheState),
            new { id = definitiveExportGoodsFollowedByAndWithReimportationInTheState.Id },
            definitiveExportGoodsFollowedByAndWithReimportationInTheState
        );
    }

    /// <summary>
    ///     Delete one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        [FromRoute] DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
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
    ///     Find many DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState>>
    > DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates(
        [FromQuery] DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateFindManyArgs filter
    )
    {
        return Ok(
            await _service.DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates(filter)
        );
    }

    /// <summary>
    ///     Meta data about DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesMeta(
        [FromQuery] DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateFindManyArgs filter
    )
    {
        return Ok(
            await _service.DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesMeta(
                filter
            )
        );
    }

    /// <summary>
    ///     Get one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState>
    > DefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        [FromRoute] DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
                uniqueId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        [FromRoute] DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId,
        [FromQuery] DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateUpdateInput
            definitiveExportGoodsFollowedByAndWithReimportationInTheStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
                uniqueId,
                definitiveExportGoodsFollowedByAndWithReimportationInTheStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
