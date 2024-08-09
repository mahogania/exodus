using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ImportedGoodsInformationsControllerBase : ControllerBase
{
    protected readonly IImportedGoodsInformationsService _service;

    public ImportedGoodsInformationsControllerBase(IImportedGoodsInformationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one IMPORTED GOODS INFORMATION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportedGoodsInformation>> CreateImportedGoodsInformation(
        ImportedGoodsInformationCreateInput input
    )
    {
        var importedGoodsInformation = await _service.CreateImportedGoodsInformation(input);

        return CreatedAtAction(
            nameof(ImportedGoodsInformation),
            new { id = importedGoodsInformation.Id },
            importedGoodsInformation
        );
    }

    /// <summary>
    /// Delete one IMPORTED GOODS INFORMATION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteImportedGoodsInformation(
        [FromRoute()] ImportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteImportedGoodsInformation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many IMPORTED GOODS INFORMATIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportedGoodsInformation>>> ImportedGoodsInformations(
        [FromQuery()] ImportedGoodsInformationFindManyArgs filter
    )
    {
        return Ok(await _service.ImportedGoodsInformations(filter));
    }

    /// <summary>
    /// Meta data about IMPORTED GOODS INFORMATION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ImportedGoodsInformationsMeta(
        [FromQuery()] ImportedGoodsInformationFindManyArgs filter
    )
    {
        return Ok(await _service.ImportedGoodsInformationsMeta(filter));
    }

    /// <summary>
    /// Get one IMPORTED GOODS INFORMATION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportedGoodsInformation>> ImportedGoodsInformation(
        [FromRoute()] ImportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ImportedGoodsInformation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one IMPORTED GOODS INFORMATION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportedGoodsInformation(
        [FromRoute()] ImportedGoodsInformationWhereUniqueInput uniqueId,
        [FromQuery()] ImportedGoodsInformationUpdateInput importedGoodsInformationUpdateDto
    )
    {
        try
        {
            await _service.UpdateImportedGoodsInformation(
                uniqueId,
                importedGoodsInformationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
