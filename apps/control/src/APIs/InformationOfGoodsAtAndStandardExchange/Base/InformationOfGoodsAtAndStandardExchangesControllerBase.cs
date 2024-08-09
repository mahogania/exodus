using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InformationOfGoodsAtAndStandardExchangesControllerBase : ControllerBase
{
    protected readonly IInformationOfGoodsAtAndStandardExchangesService _service;

    public InformationOfGoodsAtAndStandardExchangesControllerBase(
        IInformationOfGoodsAtAndStandardExchangesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InformationOfGoodsAtAndStandardExchange>
    > CreateInformationOfGoodsAtAndStandardExchange(
        InformationOfGoodsAtAndStandardExchangeCreateInput input
    )
    {
        var informationOfGoodsAtAndStandardExchange =
            await _service.CreateInformationOfGoodsAtAndStandardExchange(input);

        return CreatedAtAction(
            nameof(InformationOfGoodsAtAndStandardExchange),
            new { id = informationOfGoodsAtAndStandardExchange.Id },
            informationOfGoodsAtAndStandardExchange
        );
    }

    /// <summary>
    /// Delete one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInformationOfGoodsAtAndStandardExchange(
        [FromRoute()] InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInformationOfGoodsAtAndStandardExchange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many INFORMATION OF GOODS AT AND STANDARD EXCHANGES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InformationOfGoodsAtAndStandardExchange>>
    > InformationOfGoodsAtAndStandardExchanges(
        [FromQuery()] InformationOfGoodsAtAndStandardExchangeFindManyArgs filter
    )
    {
        return Ok(await _service.InformationOfGoodsAtAndStandardExchanges(filter));
    }

    /// <summary>
    /// Meta data about INFORMATION OF GOODS AT AND STANDARD EXCHANGE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InformationOfGoodsAtAndStandardExchangesMeta(
        [FromQuery()] InformationOfGoodsAtAndStandardExchangeFindManyArgs filter
    )
    {
        return Ok(await _service.InformationOfGoodsAtAndStandardExchangesMeta(filter));
    }

    /// <summary>
    /// Get one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InformationOfGoodsAtAndStandardExchange>
    > InformationOfGoodsAtAndStandardExchange(
        [FromRoute()] InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InformationOfGoodsAtAndStandardExchange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one INFORMATION OF GOODS AT AND STANDARD EXCHANGE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInformationOfGoodsAtAndStandardExchange(
        [FromRoute()] InformationOfGoodsAtAndStandardExchangeWhereUniqueInput uniqueId,
        [FromQuery()]
            InformationOfGoodsAtAndStandardExchangeUpdateInput informationOfGoodsAtAndStandardExchangeUpdateDto
    )
    {
        try
        {
            await _service.UpdateInformationOfGoodsAtAndStandardExchange(
                uniqueId,
                informationOfGoodsAtAndStandardExchangeUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
