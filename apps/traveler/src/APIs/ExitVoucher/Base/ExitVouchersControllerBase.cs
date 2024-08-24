using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ExitVouchersControllerBase : ControllerBase
{
    protected readonly IExitVouchersService _service;

    public ExitVouchersControllerBase(IExitVouchersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ExitVoucher
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExitVoucher>> CreateExitVoucher(ExitVoucherCreateInput input)
    {
        var exitVoucher = await _service.CreateExitVoucher(input);

        return CreatedAtAction(nameof(ExitVoucher), new { id = exitVoucher.Id }, exitVoucher);
    }

    /// <summary>
    /// Delete one ExitVoucher
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExitVoucher(
        [FromRoute()] ExitVoucherWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteExitVoucher(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ExitVouchers
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ExitVoucher>>> ExitVouchers(
        [FromQuery()] ExitVoucherFindManyArgs filter
    )
    {
        return Ok(await _service.ExitVouchers(filter));
    }

    /// <summary>
    /// Meta data about ExitVoucher records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExitVouchersMeta(
        [FromQuery()] ExitVoucherFindManyArgs filter
    )
    {
        return Ok(await _service.ExitVouchersMeta(filter));
    }

    /// <summary>
    /// Get one ExitVoucher
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExitVoucher>> ExitVoucher(
        [FromRoute()] ExitVoucherWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ExitVoucher(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ExitVoucher
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExitVoucher(
        [FromRoute()] ExitVoucherWhereUniqueInput uniqueId,
        [FromQuery()] ExitVoucherUpdateInput exitVoucherUpdateDto
    )
    {
        try
        {
            await _service.UpdateExitVoucher(uniqueId, exitVoucherUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to ExitVoucher
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] ExitVoucherWhereUniqueInput uniqueId,
        [FromQuery()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.ConnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from ExitVoucher
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] ExitVoucherWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.DisconnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for ExitVoucher
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] ExitVoucherWhereUniqueInput uniqueId,
        [FromQuery()] GeneralTravelerInformationTpdFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindGeneralTravelerInformationTpds(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for ExitVoucher
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] ExitVoucherWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.UpdateGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
