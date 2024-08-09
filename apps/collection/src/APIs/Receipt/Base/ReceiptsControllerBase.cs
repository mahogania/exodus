using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ReceiptsControllerBase : ControllerBase
{
    protected readonly IReceiptsService _service;

    public ReceiptsControllerBase(IReceiptsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one RECEIPT
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Receipt>> CreateReceipt(ReceiptCreateInput input)
    {
        var receipt = await _service.CreateReceipt(input);

        return CreatedAtAction(nameof(Receipt), new { id = receipt.Id }, receipt);
    }

    /// <summary>
    /// Delete one RECEIPT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReceipt([FromRoute()] ReceiptWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteReceipt(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many RECEIPTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Receipt>>> Receipts(
        [FromQuery()] ReceiptFindManyArgs filter
    )
    {
        return Ok(await _service.Receipts(filter));
    }

    /// <summary>
    /// Meta data about RECEIPT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReceiptsMeta(
        [FromQuery()] ReceiptFindManyArgs filter
    )
    {
        return Ok(await _service.ReceiptsMeta(filter));
    }

    /// <summary>
    /// Get one RECEIPT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Receipt>> Receipt([FromRoute()] ReceiptWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Receipt(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one RECEIPT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReceipt(
        [FromRoute()] ReceiptWhereUniqueInput uniqueId,
        [FromQuery()] ReceiptUpdateInput receiptUpdateDto
    )
    {
        try
        {
            await _service.UpdateReceipt(uniqueId, receiptUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
