using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TpdEntryAndExitHistoriesControllerBase : ControllerBase
{
    protected readonly ITpdEntryAndExitHistoriesService _service;

    public TpdEntryAndExitHistoriesControllerBase(ITpdEntryAndExitHistoriesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one TpdEntryAndExitHistory
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TpdEntryAndExitHistory>> CreateTpdEntryAndExitHistory(
        TpdEntryAndExitHistoryCreateInput input
    )
    {
        var tpdEntryAndExitHistory = await _service.CreateTpdEntryAndExitHistory(input);

        return CreatedAtAction(
            nameof(TpdEntryAndExitHistory),
            new { id = tpdEntryAndExitHistory.Id },
            tpdEntryAndExitHistory
        );
    }

    /// <summary>
    /// Delete one TpdEntryAndExitHistory
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTpdEntryAndExitHistory(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTpdEntryAndExitHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TpdEntryAndExitHistories
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TpdEntryAndExitHistory>>> TpdEntryAndExitHistories(
        [FromQuery()] TpdEntryAndExitHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.TpdEntryAndExitHistories(filter));
    }

    /// <summary>
    /// Meta data about TpdEntryAndExitHistory records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TpdEntryAndExitHistoriesMeta(
        [FromQuery()] TpdEntryAndExitHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.TpdEntryAndExitHistoriesMeta(filter));
    }

    /// <summary>
    /// Get one TpdEntryAndExitHistory
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TpdEntryAndExitHistory>> TpdEntryAndExitHistory(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TpdEntryAndExitHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TpdEntryAndExitHistory
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTpdEntryAndExitHistory(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromQuery()] TpdEntryAndExitHistoryUpdateInput tpdEntryAndExitHistoryUpdateDto
    )
    {
        try
        {
            await _service.UpdateTpdEntryAndExitHistory(uniqueId, tpdEntryAndExitHistoryUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdEntryAndExitHistory
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromQuery()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.ConnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdEntryAndExitHistory
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.DisconnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TpdEntryAndExitHistory
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromQuery()] GeneralTravelerInformationTpdFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindGeneralTravelerInformationTpds(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TpdEntryAndExitHistory
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.UpdateGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple ImportDeclarations records to TpdEntryAndExitHistory
    /// </summary>
    [HttpPost("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectImportDeclarations(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromQuery()] ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        try
        {
            await _service.ConnectImportDeclarations(uniqueId, importDeclarationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from TpdEntryAndExitHistory
    /// </summary>
    [HttpDelete("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectImportDeclarations(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromBody()] ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        try
        {
            await _service.DisconnectImportDeclarations(uniqueId, importDeclarationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple ImportDeclarations records for TpdEntryAndExitHistory
    /// </summary>
    [HttpGet("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportDeclaration>>> FindImportDeclarations(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromQuery()] ImportDeclarationFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindImportDeclarations(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple ImportDeclarations records for TpdEntryAndExitHistory
    /// </summary>
    [HttpPatch("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportDeclarations(
        [FromRoute()] TpdEntryAndExitHistoryWhereUniqueInput uniqueId,
        [FromBody()] ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        try
        {
            await _service.UpdateImportDeclarations(uniqueId, importDeclarationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
