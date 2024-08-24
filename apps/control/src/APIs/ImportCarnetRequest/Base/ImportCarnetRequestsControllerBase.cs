using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ImportCarnetRequestsControllerBase : ControllerBase
{
    protected readonly IImportCarnetRequestsService _service;

    public ImportCarnetRequestsControllerBase(IImportCarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Import Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportCarnetRequest>> CreateImportCarnetRequest(
        ImportCarnetRequestCreateInput input
    )
    {
        var importCarnetRequest = await _service.CreateImportCarnetRequest(input);

        return CreatedAtAction(
            nameof(ImportCarnetRequest),
            new { id = importCarnetRequest.Id },
            importCarnetRequest
        );
    }

    /// <summary>
    /// Delete one Import Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteImportCarnetRequest(
        [FromRoute()] ImportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteImportCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Import Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportCarnetRequest>>> ImportCarnetRequests(
        [FromQuery()] ImportCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ImportCarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Import Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ImportCarnetRequestsMeta(
        [FromQuery()] ImportCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ImportCarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Import Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportCarnetRequest>> ImportCarnetRequest(
        [FromRoute()] ImportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ImportCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Import Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportCarnetRequest(
        [FromRoute()] ImportCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ImportCarnetRequestUpdateInput importCarnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateImportCarnetRequest(uniqueId, importCarnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Import Carnet Control record for Import Carnet Request
    /// </summary>
    [HttpGet("{Id}/importCarnetControls")]
    public async Task<ActionResult<List<ImportCarnetControl>>> GetImportCarnetControl(
        [FromRoute()] ImportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var importCarnetControl = await _service.GetImportCarnetControl(uniqueId);
        return Ok(importCarnetControl);
    }
}
