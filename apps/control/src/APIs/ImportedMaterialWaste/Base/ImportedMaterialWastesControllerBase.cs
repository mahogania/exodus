using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ImportedMaterialWastesControllerBase : ControllerBase
{
    protected readonly IImportedMaterialWastesService _service;

    public ImportedMaterialWastesControllerBase(IImportedMaterialWastesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one IMPORTED MATERIAL WASTE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportedMaterialWaste>> CreateImportedMaterialWaste(
        ImportedMaterialWasteCreateInput input
    )
    {
        var importedMaterialWaste = await _service.CreateImportedMaterialWaste(input);

        return CreatedAtAction(
            nameof(ImportedMaterialWaste),
            new { id = importedMaterialWaste.Id },
            importedMaterialWaste
        );
    }

    /// <summary>
    /// Delete one IMPORTED MATERIAL WASTE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteImportedMaterialWaste(
        [FromRoute()] ImportedMaterialWasteWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteImportedMaterialWaste(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many IMPORTED MATERIAL WASTES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportedMaterialWaste>>> ImportedMaterialWastes(
        [FromQuery()] ImportedMaterialWasteFindManyArgs filter
    )
    {
        return Ok(await _service.ImportedMaterialWastes(filter));
    }

    /// <summary>
    /// Meta data about IMPORTED MATERIAL WASTE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ImportedMaterialWastesMeta(
        [FromQuery()] ImportedMaterialWasteFindManyArgs filter
    )
    {
        return Ok(await _service.ImportedMaterialWastesMeta(filter));
    }

    /// <summary>
    /// Get one IMPORTED MATERIAL WASTE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportedMaterialWaste>> ImportedMaterialWaste(
        [FromRoute()] ImportedMaterialWasteWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ImportedMaterialWaste(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one IMPORTED MATERIAL WASTE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportedMaterialWaste(
        [FromRoute()] ImportedMaterialWasteWhereUniqueInput uniqueId,
        [FromQuery()] ImportedMaterialWasteUpdateInput importedMaterialWasteUpdateDto
    )
    {
        try
        {
            await _service.UpdateImportedMaterialWaste(uniqueId, importedMaterialWasteUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
