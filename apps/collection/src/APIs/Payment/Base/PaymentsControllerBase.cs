using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PaymentsControllerBase : ControllerBase
{
    protected readonly IPaymentsService _service;

    public PaymentsControllerBase(IPaymentsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one PAYMENT
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Payment>> CreatePayment(PaymentCreateInput input)
    {
        var payment = await _service.CreatePayment(input);

        return CreatedAtAction(nameof(Payment), new { id = payment.Id }, payment);
    }

    /// <summary>
    /// Delete one PAYMENT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePayment([FromRoute()] PaymentWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeletePayment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many PAYMENTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Payment>>> Payments(
        [FromQuery()] PaymentFindManyArgs filter
    )
    {
        return Ok(await _service.Payments(filter));
    }

    /// <summary>
    /// Meta data about PAYMENT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PaymentsMeta(
        [FromQuery()] PaymentFindManyArgs filter
    )
    {
        return Ok(await _service.PaymentsMeta(filter));
    }

    /// <summary>
    /// Get one PAYMENT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Payment>> Payment([FromRoute()] PaymentWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Payment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one PAYMENT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePayment(
        [FromRoute()] PaymentWhereUniqueInput uniqueId,
        [FromQuery()] PaymentUpdateInput paymentUpdateDto
    )
    {
        try
        {
            await _service.UpdatePayment(uniqueId, paymentUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
