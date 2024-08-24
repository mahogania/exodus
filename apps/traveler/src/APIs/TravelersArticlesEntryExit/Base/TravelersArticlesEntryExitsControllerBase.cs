using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TravelersArticlesEntryExitsControllerBase : ControllerBase
{
    protected readonly ITravelersArticlesEntryExitsService _service;

    public TravelersArticlesEntryExitsControllerBase(ITravelersArticlesEntryExitsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one TravelersArticlesEntryExit
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TravelersArticlesEntryExit>> CreateTravelersArticlesEntryExit(
        TravelersArticlesEntryExitCreateInput input
    )
    {
        var travelersArticlesEntryExit = await _service.CreateTravelersArticlesEntryExit(input);

        return CreatedAtAction(
            nameof(TravelersArticlesEntryExit),
            new { id = travelersArticlesEntryExit.Id },
            travelersArticlesEntryExit
        );
    }

    /// <summary>
    /// Delete one TravelersArticlesEntryExit
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTravelersArticlesEntryExit(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTravelersArticlesEntryExit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TravelersArticlesEntryExits
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TravelersArticlesEntryExit>>> TravelersArticlesEntryExits(
        [FromQuery()] TravelersArticlesEntryExitFindManyArgs filter
    )
    {
        return Ok(await _service.TravelersArticlesEntryExits(filter));
    }

    /// <summary>
    /// Meta data about TravelersArticlesEntryExit records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TravelersArticlesEntryExitsMeta(
        [FromQuery()] TravelersArticlesEntryExitFindManyArgs filter
    )
    {
        return Ok(await _service.TravelersArticlesEntryExitsMeta(filter));
    }

    /// <summary>
    /// Get one TravelersArticlesEntryExit
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TravelersArticlesEntryExit>> TravelersArticlesEntryExit(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TravelersArticlesEntryExit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TravelersArticlesEntryExit
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTravelersArticlesEntryExit(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
        [FromQuery()] TravelersArticlesEntryExitUpdateInput travelersArticlesEntryExitUpdateDto
    )
    {
        try
        {
            await _service.UpdateTravelersArticlesEntryExit(
                uniqueId,
                travelersArticlesEntryExitUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TravelersArticlesEntryExit
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from TravelersArticlesEntryExit
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for TravelersArticlesEntryExit
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for TravelersArticlesEntryExit
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
    /// Connect multiple ImportDeclarations records to TravelersArticlesEntryExit
    /// </summary>
    [HttpPost("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectImportDeclarations(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
    /// Disconnect multiple ImportDeclarations records from TravelersArticlesEntryExit
    /// </summary>
    [HttpDelete("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectImportDeclarations(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
    /// Find multiple ImportDeclarations records for TravelersArticlesEntryExit
    /// </summary>
    [HttpGet("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportDeclaration>>> FindImportDeclarations(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
    /// Update multiple ImportDeclarations records for TravelersArticlesEntryExit
    /// </summary>
    [HttpPatch("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportDeclarations(
        [FromRoute()] TravelersArticlesEntryExitWhereUniqueInput uniqueId,
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
