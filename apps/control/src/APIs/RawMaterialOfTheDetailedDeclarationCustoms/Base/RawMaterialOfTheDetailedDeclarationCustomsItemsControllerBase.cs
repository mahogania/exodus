using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class RawMaterialOfTheDetailedDeclarationCustomsItemsControllerBase : ControllerBase
{
    protected readonly IRawMaterialOfTheDetailedDeclarationCustomsItemsService _service;

    public RawMaterialOfTheDetailedDeclarationCustomsItemsControllerBase(
        IRawMaterialOfTheDetailedDeclarationCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RawMaterialOfTheDetailedDeclarationCustoms>
    > CreateRawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsCreateInput input
    )
    {
        var rawMaterialOfTheDetailedDeclarationCustoms =
            await _service.CreateRawMaterialOfTheDetailedDeclarationCustoms(input);

        return CreatedAtAction(
            nameof(RawMaterialOfTheDetailedDeclarationCustoms),
            new { id = rawMaterialOfTheDetailedDeclarationCustoms.Id },
            rawMaterialOfTheDetailedDeclarationCustoms
        );
    }

    /// <summary>
    ///     Delete one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRawMaterialOfTheDetailedDeclarationCustoms(
        [FromRoute] RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRawMaterialOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<RawMaterialOfTheDetailedDeclarationCustoms>>
    > RawMaterialOfTheDetailedDeclarationCustomsItems(
        [FromQuery] RawMaterialOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.RawMaterialOfTheDetailedDeclarationCustomsItems(filter));
    }

    /// <summary>
    ///     Meta data about RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > RawMaterialOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery] RawMaterialOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.RawMaterialOfTheDetailedDeclarationCustomsItemsMeta(filter));
    }

    /// <summary>
    ///     Get one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RawMaterialOfTheDetailedDeclarationCustoms>
    > RawMaterialOfTheDetailedDeclarationCustoms(
        [FromRoute] RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RawMaterialOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRawMaterialOfTheDetailedDeclarationCustoms(
        [FromRoute] RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery]
        RawMaterialOfTheDetailedDeclarationCustomsUpdateInput rawMaterialOfTheDetailedDeclarationCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateRawMaterialOfTheDetailedDeclarationCustoms(
                uniqueId,
                rawMaterialOfTheDetailedDeclarationCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
