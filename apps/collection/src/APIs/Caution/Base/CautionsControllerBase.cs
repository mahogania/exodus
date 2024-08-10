using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class CautionsControllerBase : ControllerBase
{
    protected readonly ICautionsService _service;

    public CautionsControllerBase(ICautionsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one CAUTION
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Caution>> CreateCaution(CautionCreateInput input)
    {
        var caution = await _service.CreateCaution(input);

        return CreatedAtAction(nameof(Caution), new { id = caution.Id }, caution);
    }

    /// <summary>
    ///     Delete one CAUTION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCaution([FromRoute] CautionWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteCaution(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many CAUTIONS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Caution>>> Cautions(
        [FromQuery] CautionFindManyArgs filter
    )
    {
        return Ok(await _service.Cautions(filter));
    }

    /// <summary>
    ///     Meta data about CAUTION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CautionsMeta(
        [FromQuery] CautionFindManyArgs filter
    )
    {
        return Ok(await _service.CautionsMeta(filter));
    }

    /// <summary>
    ///     Get one CAUTION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Caution>> Caution([FromRoute] CautionWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Caution(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one CAUTION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCaution(
        [FromRoute] CautionWhereUniqueInput uniqueId,
        [FromQuery] CautionUpdateInput cautionUpdateDto
    )
    {
        try
        {
            await _service.UpdateCaution(uniqueId, cautionUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
