using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class GeneralBondNotesControllerBase : ControllerBase
{
    protected readonly IGeneralBondNotesService _service;

    public GeneralBondNotesControllerBase(IGeneralBondNotesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one GeneralBondNote
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<GeneralBondNote>> CreateGeneralBondNote(
        GeneralBondNoteCreateInput input
    )
    {
        var generalBondNote = await _service.CreateGeneralBondNote(input);

        return CreatedAtAction(
            nameof(GeneralBondNote),
            new { id = generalBondNote.Id },
            generalBondNote
        );
    }

    /// <summary>
    /// Delete one GeneralBondNote
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteGeneralBondNote(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteGeneralBondNote(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many GeneralBondNotes
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<GeneralBondNote>>> GeneralBondNotes(
        [FromQuery()] GeneralBondNoteFindManyArgs filter
    )
    {
        return Ok(await _service.GeneralBondNotes(filter));
    }

    /// <summary>
    /// Meta data about GeneralBondNote records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> GeneralBondNotesMeta(
        [FromQuery()] GeneralBondNoteFindManyArgs filter
    )
    {
        return Ok(await _service.GeneralBondNotesMeta(filter));
    }

    /// <summary>
    /// Get one GeneralBondNote
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<GeneralBondNote>> GeneralBondNote(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.GeneralBondNote(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one GeneralBondNote
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralBondNote(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
        [FromQuery()] GeneralBondNoteUpdateInput generalBondNoteUpdateDto
    )
    {
        try
        {
            await _service.UpdateGeneralBondNote(uniqueId, generalBondNoteUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Appeals records to GeneralBondNote
    /// </summary>
    [HttpPost("{Id}/appeals")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectAppeals(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
        [FromQuery()] AppealWhereUniqueInput[] appealsId
    )
    {
        try
        {
            await _service.ConnectAppeals(uniqueId, appealsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Appeals records from GeneralBondNote
    /// </summary>
    [HttpDelete("{Id}/appeals")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectAppeals(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
        [FromBody()] AppealWhereUniqueInput[] appealsId
    )
    {
        try
        {
            await _service.DisconnectAppeals(uniqueId, appealsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Appeals records for GeneralBondNote
    /// </summary>
    [HttpGet("{Id}/appeals")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Appeal>>> FindAppeals(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
        [FromQuery()] AppealFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindAppeals(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Appeals records for GeneralBondNote
    /// </summary>
    [HttpPatch("{Id}/appeals")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAppeals(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
        [FromBody()] AppealWhereUniqueInput[] appealsId
    )
    {
        try
        {
            await _service.UpdateAppeals(uniqueId, appealsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to GeneralBondNote
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from GeneralBondNote
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for GeneralBondNote
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for GeneralBondNote
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] GeneralBondNoteWhereUniqueInput uniqueId,
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
}
