using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class FinalExportFollowedByReimportationInTheStatesControllerBase : ControllerBase
{
    protected readonly IFinalExportFollowedByReimportationInTheStatesService _service;

    public FinalExportFollowedByReimportationInTheStatesControllerBase(
        IFinalExportFollowedByReimportationInTheStatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<FinalExportFollowedByReimportationInTheState>
    > CreateFinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateCreateInput input
    )
    {
        var finalExportFollowedByReimportationInTheState =
            await _service.CreateFinalExportFollowedByReimportationInTheState(input);

        return CreatedAtAction(
            nameof(FinalExportFollowedByReimportationInTheState),
            new { id = finalExportFollowedByReimportationInTheState.Id },
            finalExportFollowedByReimportationInTheState
        );
    }

    /// <summary>
    /// Delete one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteFinalExportFollowedByReimportationInTheState(
        [FromRoute()] FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteFinalExportFollowedByReimportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<FinalExportFollowedByReimportationInTheState>>
    > FinalExportFollowedByReimportationInTheStates(
        [FromQuery()] FinalExportFollowedByReimportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.FinalExportFollowedByReimportationInTheStates(filter));
    }

    /// <summary>
    /// Meta data about FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> FinalExportFollowedByReimportationInTheStatesMeta(
        [FromQuery()] FinalExportFollowedByReimportationInTheStateFindManyArgs filter
    )
    {
        return Ok(await _service.FinalExportFollowedByReimportationInTheStatesMeta(filter));
    }

    /// <summary>
    /// Get one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<FinalExportFollowedByReimportationInTheState>
    > FinalExportFollowedByReimportationInTheState(
        [FromRoute()] FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.FinalExportFollowedByReimportationInTheState(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateFinalExportFollowedByReimportationInTheState(
        [FromRoute()] FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId,
        [FromQuery()]
            FinalExportFollowedByReimportationInTheStateUpdateInput finalExportFollowedByReimportationInTheStateUpdateDto
    )
    {
        try
        {
            await _service.UpdateFinalExportFollowedByReimportationInTheState(
                uniqueId,
                finalExportFollowedByReimportationInTheStateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
