using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class AtAndStandardExchangesControllerBase : ControllerBase
{
    protected readonly IAtAndStandardExchangesService _service;

    public AtAndStandardExchangesControllerBase(IAtAndStandardExchangesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one AT? AND STANDARD EXCHANGE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AtAndStandardExchange>> CreateAtAndStandardExchange(
        AtAndStandardExchangeCreateInput input
    )
    {
        var atAndStandardExchange = await _service.CreateAtAndStandardExchange(input);

        return CreatedAtAction(
            nameof(AtAndStandardExchange),
            new { id = atAndStandardExchange.Id },
            atAndStandardExchange
        );
    }

    /// <summary>
    ///     Delete one AT? AND STANDARD EXCHANGE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAtAndStandardExchange(
        [FromRoute] AtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAtAndStandardExchange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many AT? AND STANDARD EXCHANGES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<AtAndStandardExchange>>> AtAndStandardExchanges(
        [FromQuery] AtAndStandardExchangeFindManyArgs filter
    )
    {
        return Ok(await _service.AtAndStandardExchanges(filter));
    }

    /// <summary>
    ///     Meta data about AT? AND STANDARD EXCHANGE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AtAndStandardExchangesMeta(
        [FromQuery] AtAndStandardExchangeFindManyArgs filter
    )
    {
        return Ok(await _service.AtAndStandardExchangesMeta(filter));
    }

    /// <summary>
    ///     Get one AT? AND STANDARD EXCHANGE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AtAndStandardExchange>> AtAndStandardExchange(
        [FromRoute] AtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.AtAndStandardExchange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one AT? AND STANDARD EXCHANGE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAtAndStandardExchange(
        [FromRoute] AtAndStandardExchangeWhereUniqueInput uniqueId,
        [FromQuery] AtAndStandardExchangeUpdateInput atAndStandardExchangeUpdateDto
    )
    {
        try
        {
            await _service.UpdateAtAndStandardExchange(uniqueId, atAndStandardExchangeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
