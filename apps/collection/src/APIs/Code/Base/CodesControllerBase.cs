using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class CodesControllerBase : ControllerBase
{
    protected readonly ICodesService _service;

    public CodesControllerBase(ICodesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one CODE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Code>> CreateCode(CodeCreateInput input)
    {
        var code = await _service.CreateCode(input);

        return CreatedAtAction(nameof(Code), new { id = code.Id }, code);
    }

    /// <summary>
    ///     Delete one CODE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCode([FromRoute] CodeWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteCode(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many CODES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Code>>> Codes([FromQuery] CodeFindManyArgs filter)
    {
        return Ok(await _service.Codes(filter));
    }

    /// <summary>
    ///     Meta data about CODE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CodesMeta([FromQuery] CodeFindManyArgs filter)
    {
        return Ok(await _service.CodesMeta(filter));
    }

    /// <summary>
    ///     Get one CODE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Code>> Code([FromRoute] CodeWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Code(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one CODE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCode(
        [FromRoute] CodeWhereUniqueInput uniqueId,
        [FromQuery] CodeUpdateInput codeUpdateDto
    )
    {
        try
        {
            await _service.UpdateCode(uniqueId, codeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
