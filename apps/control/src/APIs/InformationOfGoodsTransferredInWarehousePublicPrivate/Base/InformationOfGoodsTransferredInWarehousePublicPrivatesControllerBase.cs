using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class InformationOfGoodsTransferredInWarehousePublicPrivatesControllerBase
    : ControllerBase
{
    protected readonly IInformationOfGoodsTransferredInWarehousePublicPrivatesService _service;

    public InformationOfGoodsTransferredInWarehousePublicPrivatesControllerBase(
        IInformationOfGoodsTransferredInWarehousePublicPrivatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InformationOfGoodsTransferredInWarehousePublicPrivate>
    > CreateInformationOfGoodsTransferredInWarehousePublicPrivate(
        InformationOfGoodsTransferredInWarehousePublicPrivateCreateInput input
    )
    {
        var informationOfGoodsTransferredInWarehousePublicPrivate =
            await _service.CreateInformationOfGoodsTransferredInWarehousePublicPrivate(input);

        return CreatedAtAction(
            nameof(InformationOfGoodsTransferredInWarehousePublicPrivate),
            new { id = informationOfGoodsTransferredInWarehousePublicPrivate.Id },
            informationOfGoodsTransferredInWarehousePublicPrivate
        );
    }

    /// <summary>
    ///     Delete one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInformationOfGoodsTransferredInWarehousePublicPrivate(
        [FromRoute] InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInformationOfGoodsTransferredInWarehousePublicPrivate(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)s
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InformationOfGoodsTransferredInWarehousePublicPrivate>>
    > InformationOfGoodsTransferredInWarehousePublicPrivates(
        [FromQuery] InformationOfGoodsTransferredInWarehousePublicPrivateFindManyArgs filter
    )
    {
        return Ok(await _service.InformationOfGoodsTransferredInWarehousePublicPrivates(filter));
    }

    /// <summary>
    ///     Meta data about INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > InformationOfGoodsTransferredInWarehousePublicPrivatesMeta(
        [FromQuery] InformationOfGoodsTransferredInWarehousePublicPrivateFindManyArgs filter
    )
    {
        return Ok(
            await _service.InformationOfGoodsTransferredInWarehousePublicPrivatesMeta(filter)
        );
    }

    /// <summary>
    ///     Get one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InformationOfGoodsTransferredInWarehousePublicPrivate>
    > InformationOfGoodsTransferredInWarehousePublicPrivate(
        [FromRoute] InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InformationOfGoodsTransferredInWarehousePublicPrivate(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one INFORMATION OF GOODS TRANSFERRED IN WAREHOUSE (PUBLIC, PRIVATE)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInformationOfGoodsTransferredInWarehousePublicPrivate(
        [FromRoute] InformationOfGoodsTransferredInWarehousePublicPrivateWhereUniqueInput uniqueId,
        [FromQuery] InformationOfGoodsTransferredInWarehousePublicPrivateUpdateInput
            informationOfGoodsTransferredInWarehousePublicPrivateUpdateDto
    )
    {
        try
        {
            await _service.UpdateInformationOfGoodsTransferredInWarehousePublicPrivate(
                uniqueId,
                informationOfGoodsTransferredInWarehousePublicPrivateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
