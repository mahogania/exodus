using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ImportCarnetControlsControllerBase : ControllerBase
{
    protected readonly IImportCarnetControlsService _service;

    public ImportCarnetControlsControllerBase(IImportCarnetControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Import Carnet Control
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportCarnetControl>> CreateImportCarnetControl(
        ImportCarnetControlCreateInput input
    )
    {
        var importCarnetControl = await _service.CreateImportCarnetControl(input);

        return CreatedAtAction(
            nameof(ImportCarnetControl),
            new { id = importCarnetControl.Id },
            importCarnetControl
        );
    }

    /// <summary>
    /// Delete one Import Carnet Control
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteImportCarnetControl(
        [FromRoute()] ImportCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteImportCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Import Carnet Controls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportCarnetControl>>> ImportCarnetControls(
        [FromQuery()] ImportCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ImportCarnetControls(filter));
    }

    /// <summary>
    /// Meta data about Import Carnet Control records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ImportCarnetControlsMeta(
        [FromQuery()] ImportCarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.ImportCarnetControlsMeta(filter));
    }

    /// <summary>
    /// Get one Import Carnet Control
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportCarnetControl>> ImportCarnetControl(
        [FromRoute()] ImportCarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ImportCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Import Carnet Control
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportCarnetControl(
        [FromRoute()] ImportCarnetControlWhereUniqueInput uniqueId,
        [FromQuery()] ImportCarnetControlUpdateInput importCarnetControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateImportCarnetControl(uniqueId, importCarnetControlUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Import Carnet Request record for Import Carnet Control
    /// </summary>
    [HttpGet("{Id}/importCarnetRequests")]
    public async Task<ActionResult<List<ImportCarnetRequest>>> GetImportCarnetRequest(
        [FromRoute()] ImportCarnetControlWhereUniqueInput uniqueId
    )
    {
        var importCarnetRequest = await _service.GetImportCarnetRequest(uniqueId);
        return Ok(importCarnetRequest);
    }
}
