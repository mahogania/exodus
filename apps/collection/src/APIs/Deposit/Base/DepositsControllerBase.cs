using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class DepositsControllerBase : ControllerBase
{
    protected readonly IDepositsService _service;

    public DepositsControllerBase(IDepositsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one DEPOSIT
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Deposit>> CreateDeposit(DepositCreateInput input)
    {
        var deposit = await _service.CreateDeposit(input);

        return CreatedAtAction(nameof(Deposit), new { id = deposit.Id }, deposit);
    }

    /// <summary>
    ///     Delete one DEPOSIT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDeposit([FromRoute] DepositWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteDeposit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many DEPOSITS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Deposit>>> Deposits(
        [FromQuery] DepositFindManyArgs filter
    )
    {
        return Ok(await _service.Deposits(filter));
    }

    /// <summary>
    ///     Meta data about DEPOSIT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DepositsMeta(
        [FromQuery] DepositFindManyArgs filter
    )
    {
        return Ok(await _service.DepositsMeta(filter));
    }

    /// <summary>
    ///     Get one DEPOSIT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Deposit>> Deposit([FromRoute] DepositWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Deposit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one DEPOSIT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDeposit(
        [FromRoute] DepositWhereUniqueInput uniqueId,
        [FromQuery] DepositUpdateInput depositUpdateDto
    )
    {
        try
        {
            await _service.UpdateDeposit(uniqueId, depositUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
