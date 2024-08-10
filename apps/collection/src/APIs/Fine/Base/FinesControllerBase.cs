using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class FinesControllerBase : ControllerBase
{
    protected readonly IFinesService _service;

    public FinesControllerBase(IFinesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one FINE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Fine>> CreateFine(FineCreateInput input)
    {
        var fine = await _service.CreateFine(input);

        return CreatedAtAction(nameof(Fine), new { id = fine.Id }, fine);
    }

    /// <summary>
    ///     Delete one FINE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteFine([FromRoute] FineWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteFine(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many FINES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Fine>>> Fines([FromQuery] FineFindManyArgs filter)
    {
        return Ok(await _service.Fines(filter));
    }

    /// <summary>
    ///     Meta data about FINE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> FinesMeta([FromQuery] FineFindManyArgs filter)
    {
        return Ok(await _service.FinesMeta(filter));
    }

    /// <summary>
    ///     Get one FINE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Fine>> Fine([FromRoute] FineWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Fine(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one FINE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateFine(
        [FromRoute] FineWhereUniqueInput uniqueId,
        [FromQuery] FineUpdateInput fineUpdateDto
    )
    {
        try
        {
            await _service.UpdateFine(uniqueId, fineUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
