using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ExportedOrToBeExportedGoodsInformationsControllerBase : ControllerBase
{
    protected readonly IExportedOrToBeExportedGoodsInformationsService _service;

    public ExportedOrToBeExportedGoodsInformationsControllerBase(
        IExportedOrToBeExportedGoodsInformationsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ExportedOrToBeExportedGoodsInformation>
    > CreateExportedOrToBeExportedGoodsInformation(
        ExportedOrToBeExportedGoodsInformationCreateInput input
    )
    {
        var exportedOrToBeExportedGoodsInformation =
            await _service.CreateExportedOrToBeExportedGoodsInformation(input);

        return CreatedAtAction(
            nameof(ExportedOrToBeExportedGoodsInformation),
            new { id = exportedOrToBeExportedGoodsInformation.Id },
            exportedOrToBeExportedGoodsInformation
        );
    }

    /// <summary>
    /// Delete one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExportedOrToBeExportedGoodsInformation(
        [FromRoute()] ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteExportedOrToBeExportedGoodsInformation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many EXPORTED OR TO BE EXPORTED GOODS INFORMATIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ExportedOrToBeExportedGoodsInformation>>
    > ExportedOrToBeExportedGoodsInformations(
        [FromQuery()] ExportedOrToBeExportedGoodsInformationFindManyArgs filter
    )
    {
        return Ok(await _service.ExportedOrToBeExportedGoodsInformations(filter));
    }

    /// <summary>
    /// Meta data about EXPORTED OR TO BE EXPORTED GOODS INFORMATION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExportedOrToBeExportedGoodsInformationsMeta(
        [FromQuery()] ExportedOrToBeExportedGoodsInformationFindManyArgs filter
    )
    {
        return Ok(await _service.ExportedOrToBeExportedGoodsInformationsMeta(filter));
    }

    /// <summary>
    /// Get one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ExportedOrToBeExportedGoodsInformation>
    > ExportedOrToBeExportedGoodsInformation(
        [FromRoute()] ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ExportedOrToBeExportedGoodsInformation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one EXPORTED OR TO BE EXPORTED GOODS INFORMATION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExportedOrToBeExportedGoodsInformation(
        [FromRoute()] ExportedOrToBeExportedGoodsInformationWhereUniqueInput uniqueId,
        [FromQuery()]
            ExportedOrToBeExportedGoodsInformationUpdateInput exportedOrToBeExportedGoodsInformationUpdateDto
    )
    {
        try
        {
            await _service.UpdateExportedOrToBeExportedGoodsInformation(
                uniqueId,
                exportedOrToBeExportedGoodsInformationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
