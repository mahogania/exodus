using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorQuotationModesControllerBase : ControllerBase
{
    protected readonly IInspectorQuotationModesService _service;

    public InspectorQuotationModesControllerBase(IInspectorQuotationModesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Quotation Mode
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorQuotationMode>> CreateInspectorQuotationMode(
        InspectorQuotationModeCreateInput input
    )
    {
        var inspectorQuotationMode = await _service.CreateInspectorQuotationMode(input);

        return CreatedAtAction(
            nameof(InspectorQuotationMode),
            new { id = inspectorQuotationMode.Id },
            inspectorQuotationMode
        );
    }

    /// <summary>
    /// Delete one Inspector Quotation Mode
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorQuotationMode(
        [FromRoute()] InspectorQuotationModeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorQuotationMode(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Quotation Modes
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<InspectorQuotationMode>>> InspectorQuotationModes(
        [FromQuery()] InspectorQuotationModeFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorQuotationModes(filter));
    }

    /// <summary>
    /// Meta data about Inspector Quotation Mode records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorQuotationModesMeta(
        [FromQuery()] InspectorQuotationModeFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorQuotationModesMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Quotation Mode
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorQuotationMode>> InspectorQuotationMode(
        [FromRoute()] InspectorQuotationModeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorQuotationMode(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Inspector Quotation Mode
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorQuotationMode(
        [FromRoute()] InspectorQuotationModeWhereUniqueInput uniqueId,
        [FromQuery()] InspectorQuotationModeUpdateInput inspectorQuotationModeUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorQuotationMode(uniqueId, inspectorQuotationModeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
