using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class ReceptionsControllerBase : ControllerBase
{
    protected readonly IReceptionsService _service;

    public ReceptionsControllerBase(IReceptionsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one RECEPTION
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Reception>> CreateReception(ReceptionCreateInput input)
    {
        var reception = await _service.CreateReception(input);

        return CreatedAtAction(nameof(Reception), new { id = reception.Id }, reception);
    }

    /// <summary>
    ///     Delete one RECEPTION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReception(
        [FromRoute] ReceptionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReception(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many RECEPTIONS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Reception>>> Receptions(
        [FromQuery] ReceptionFindManyArgs filter
    )
    {
        return Ok(await _service.Receptions(filter));
    }

    /// <summary>
    ///     Meta data about RECEPTION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReceptionsMeta(
        [FromQuery] ReceptionFindManyArgs filter
    )
    {
        return Ok(await _service.ReceptionsMeta(filter));
    }

    /// <summary>
    ///     Get one RECEPTION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Reception>> Reception(
        [FromRoute] ReceptionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Reception(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one RECEPTION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReception(
        [FromRoute] ReceptionWhereUniqueInput uniqueId,
        [FromQuery] ReceptionUpdateInput receptionUpdateDto
    )
    {
        try
        {
            await _service.UpdateReception(uniqueId, receptionUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
