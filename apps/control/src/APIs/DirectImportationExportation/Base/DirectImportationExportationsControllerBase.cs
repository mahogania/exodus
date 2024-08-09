using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DirectImportationExportationsControllerBase : ControllerBase
{
    protected readonly IDirectImportationExportationsService _service;

    public DirectImportationExportationsControllerBase(
        IDirectImportationExportationsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DirectImportationExportation>
    > CreateDirectImportationExportation(DirectImportationExportationCreateInput input)
    {
        var directImportationExportation = await _service.CreateDirectImportationExportation(input);

        return CreatedAtAction(
            nameof(DirectImportationExportation),
            new { id = directImportationExportation.Id },
            directImportationExportation
        );
    }

    /// <summary>
    /// Delete one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDirectImportationExportation(
        [FromRoute()] DirectImportationExportationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDirectImportationExportation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DIRECT IMPORTATION/EXPORTATIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DirectImportationExportation>>
    > DirectImportationExportations([FromQuery()] DirectImportationExportationFindManyArgs filter)
    {
        return Ok(await _service.DirectImportationExportations(filter));
    }

    /// <summary>
    /// Meta data about DIRECT IMPORTATION/EXPORTATION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DirectImportationExportationsMeta(
        [FromQuery()] DirectImportationExportationFindManyArgs filter
    )
    {
        return Ok(await _service.DirectImportationExportationsMeta(filter));
    }

    /// <summary>
    /// Get one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DirectImportationExportation>> DirectImportationExportation(
        [FromRoute()] DirectImportationExportationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DirectImportationExportation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DIRECT IMPORTATION/EXPORTATION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDirectImportationExportation(
        [FromRoute()] DirectImportationExportationWhereUniqueInput uniqueId,
        [FromQuery()] DirectImportationExportationUpdateInput directImportationExportationUpdateDto
    )
    {
        try
        {
            await _service.UpdateDirectImportationExportation(
                uniqueId,
                directImportationExportationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
