using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class AccountingsControllerBase : ControllerBase
{
    protected readonly IAccountingsService _service;

    public AccountingsControllerBase(IAccountingsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one ACCOUNTING
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Accounting>> CreateAccounting(AccountingCreateInput input)
    {
        var accounting = await _service.CreateAccounting(input);

        return CreatedAtAction(nameof(Accounting), new { id = accounting.Id }, accounting);
    }

    /// <summary>
    ///     Delete one ACCOUNTING
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAccounting(
        [FromRoute] AccountingWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAccounting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many ACCOUNTINGS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Accounting>>> Accountings(
        [FromQuery] AccountingFindManyArgs filter
    )
    {
        return Ok(await _service.Accountings(filter));
    }

    /// <summary>
    ///     Meta data about ACCOUNTING records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AccountingsMeta(
        [FromQuery] AccountingFindManyArgs filter
    )
    {
        return Ok(await _service.AccountingsMeta(filter));
    }

    /// <summary>
    ///     Get one ACCOUNTING
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Accounting>> Accounting(
        [FromRoute] AccountingWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Accounting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one ACCOUNTING
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAccounting(
        [FromRoute] AccountingWhereUniqueInput uniqueId,
        [FromQuery] AccountingUpdateInput accountingUpdateDto
    )
    {
        try
        {
            await _service.UpdateAccounting(uniqueId, accountingUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
