using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CreditsControllerBase : ControllerBase
{
    protected readonly ICreditsService _service;

    public CreditsControllerBase(ICreditsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one CREDIT
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Credit>> CreateCredit(CreditCreateInput input)
    {
        var credit = await _service.CreateCredit(input);

        return CreatedAtAction(nameof(Credit), new { id = credit.Id }, credit);
    }

    /// <summary>
    /// Delete one CREDIT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCredit([FromRoute()] CreditWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteCredit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many CREDITS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Credit>>> Credits([FromQuery()] CreditFindManyArgs filter)
    {
        return Ok(await _service.Credits(filter));
    }

    /// <summary>
    /// Meta data about CREDIT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CreditsMeta(
        [FromQuery()] CreditFindManyArgs filter
    )
    {
        return Ok(await _service.CreditsMeta(filter));
    }

    /// <summary>
    /// Get one CREDIT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Credit>> Credit([FromRoute()] CreditWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Credit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one CREDIT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCredit(
        [FromRoute()] CreditWhereUniqueInput uniqueId,
        [FromQuery()] CreditUpdateInput creditUpdateDto
    )
    {
        try
        {
            await _service.UpdateCredit(uniqueId, creditUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
