using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class ReimbursementsControllerBase : ControllerBase
{
    protected readonly IReimbursementsService _service;

    public ReimbursementsControllerBase(IReimbursementsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one REIMBURSEMENT
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Reimbursement>> CreateReimbursement(
        ReimbursementCreateInput input
    )
    {
        var reimbursement = await _service.CreateReimbursement(input);

        return CreatedAtAction(nameof(Reimbursement), new { id = reimbursement.Id }, reimbursement);
    }

    /// <summary>
    ///     Delete one REIMBURSEMENT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReimbursement(
        [FromRoute] ReimbursementWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReimbursement(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many REIMBURSEMENTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Reimbursement>>> Reimbursements(
        [FromQuery] ReimbursementFindManyArgs filter
    )
    {
        return Ok(await _service.Reimbursements(filter));
    }

    /// <summary>
    ///     Meta data about REIMBURSEMENT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReimbursementsMeta(
        [FromQuery] ReimbursementFindManyArgs filter
    )
    {
        return Ok(await _service.ReimbursementsMeta(filter));
    }

    /// <summary>
    ///     Get one REIMBURSEMENT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Reimbursement>> Reimbursement(
        [FromRoute] ReimbursementWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Reimbursement(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one REIMBURSEMENT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReimbursement(
        [FromRoute] ReimbursementWhereUniqueInput uniqueId,
        [FromQuery] ReimbursementUpdateInput reimbursementUpdateDto
    )
    {
        try
        {
            await _service.UpdateReimbursement(uniqueId, reimbursementUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
