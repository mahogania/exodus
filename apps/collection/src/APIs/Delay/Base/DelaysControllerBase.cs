using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class DelaysControllerBase : ControllerBase
{
    protected readonly IDelaysService _service;

    public DelaysControllerBase(IDelaysService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one DELAY
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Delay>> CreateDelay(DelayCreateInput input)
    {
        var delay = await _service.CreateDelay(input);

        return CreatedAtAction(nameof(Delay), new { id = delay.Id }, delay);
    }

    /// <summary>
    ///     Delete one DELAY
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDelay([FromRoute] DelayWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteDelay(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many DELAYS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Delay>>> Delays([FromQuery] DelayFindManyArgs filter)
    {
        return Ok(await _service.Delays(filter));
    }

    /// <summary>
    ///     Meta data about DELAY records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DelaysMeta([FromQuery] DelayFindManyArgs filter)
    {
        return Ok(await _service.DelaysMeta(filter));
    }

    /// <summary>
    ///     Get one DELAY
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Delay>> Delay([FromRoute] DelayWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Delay(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one DELAY
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDelay(
        [FromRoute] DelayWhereUniqueInput uniqueId,
        [FromQuery] DelayUpdateInput delayUpdateDto
    )
    {
        try
        {
            await _service.UpdateDelay(uniqueId, delayUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
