using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class ProceduresControllerBase : ControllerBase
{
    protected readonly IProceduresService _service;

    public ProceduresControllerBase(IProceduresService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one PROCEDURE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Procedure>> CreateProcedure(ProcedureCreateInput input)
    {
        var procedure = await _service.CreateProcedure(input);

        return CreatedAtAction(nameof(Procedure), new { id = procedure.Id }, procedure);
    }

    /// <summary>
    ///     Delete one PROCEDURE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteProcedure(
        [FromRoute] ProcedureWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteProcedure(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many PROCEDURES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Procedure>>> Procedures(
        [FromQuery] ProcedureFindManyArgs filter
    )
    {
        return Ok(await _service.Procedures(filter));
    }

    /// <summary>
    ///     Meta data about PROCEDURE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ProceduresMeta(
        [FromQuery] ProcedureFindManyArgs filter
    )
    {
        return Ok(await _service.ProceduresMeta(filter));
    }

    /// <summary>
    ///     Get one PROCEDURE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Procedure>> Procedure(
        [FromRoute] ProcedureWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Procedure(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one PROCEDURE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateProcedure(
        [FromRoute] ProcedureWhereUniqueInput uniqueId,
        [FromQuery] ProcedureUpdateInput procedureUpdateDto
    )
    {
        try
        {
            await _service.UpdateProcedure(uniqueId, procedureUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
