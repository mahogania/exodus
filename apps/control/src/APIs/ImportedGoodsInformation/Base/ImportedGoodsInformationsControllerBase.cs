using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

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
    /// Create one Imported Goods Information
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
    /// Delete one Imported Goods Information
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
    /// Meta data about Imported Goods Information records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ImportedGoodsInformationsMeta(
        [FromQuery()] ImportedGoodsInformationFindManyArgs filter
    )
    {
        return Ok(await _service.ImportedGoodsInformationsMeta(filter));
    }

    /// <summary>
    /// Get one Imported Goods Information
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
    /// Update one Imported Goods Information
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
