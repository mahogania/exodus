using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class CustomsDeclarationBondsControllerBase : ControllerBase
{
    protected readonly ICustomsDeclarationBondsService _service;

    public CustomsDeclarationBondsControllerBase(ICustomsDeclarationBondsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one CUSTOMS DECLARATION BOND
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CustomsDeclarationBond>> CreateCustomsDeclarationBond(
        CustomsDeclarationBondCreateInput input
    )
    {
        var customsDeclarationBond = await _service.CreateCustomsDeclarationBond(input);

        return CreatedAtAction(
            nameof(CustomsDeclarationBond),
            new { id = customsDeclarationBond.Id },
            customsDeclarationBond
        );
    }

    /// <summary>
    ///     Delete one CUSTOMS DECLARATION BOND
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCustomsDeclarationBond(
        [FromRoute] CustomsDeclarationBondWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCustomsDeclarationBond(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many CUSTOMS DECLARATION BONDS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CustomsDeclarationBond>>> CustomsDeclarationBonds(
        [FromQuery] CustomsDeclarationBondFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsDeclarationBonds(filter));
    }

    /// <summary>
    ///     Meta data about CUSTOMS DECLARATION BOND records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CustomsDeclarationBondsMeta(
        [FromQuery] CustomsDeclarationBondFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsDeclarationBondsMeta(filter));
    }

    /// <summary>
    ///     Get one CUSTOMS DECLARATION BOND
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CustomsDeclarationBond>> CustomsDeclarationBond(
        [FromRoute] CustomsDeclarationBondWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CustomsDeclarationBond(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one CUSTOMS DECLARATION BOND
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCustomsDeclarationBond(
        [FromRoute] CustomsDeclarationBondWhereUniqueInput uniqueId,
        [FromQuery] CustomsDeclarationBondUpdateInput customsDeclarationBondUpdateDto
    )
    {
        try
        {
            await _service.UpdateCustomsDeclarationBond(uniqueId, customsDeclarationBondUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
