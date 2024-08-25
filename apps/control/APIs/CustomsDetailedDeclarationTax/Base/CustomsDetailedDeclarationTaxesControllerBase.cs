using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class CustomsDetailedDeclarationTaxesControllerBase : ControllerBase
{
    protected readonly ICustomsDetailedDeclarationTaxesService _service;

    public CustomsDetailedDeclarationTaxesControllerBase(
        ICustomsDetailedDeclarationTaxesService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CustomsDetailedDeclarationTax>
    > CreateCustomsDetailedDeclarationTax(CustomsDetailedDeclarationTaxCreateInput input)
    {
        var customsDetailedDeclarationTax = await _service.CreateCustomsDetailedDeclarationTax(
            input
        );

        return CreatedAtAction(
            nameof(CustomsDetailedDeclarationTax),
            new { id = customsDetailedDeclarationTax.Id },
            customsDetailedDeclarationTax
        );
    }

    /// <summary>
    ///     Delete one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCustomsDetailedDeclarationTax(
        [FromRoute] CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCustomsDetailedDeclarationTax(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many CUSTOMS DETAILED DECLARATION TAXES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<CustomsDetailedDeclarationTax>>
    > CustomsDetailedDeclarationTaxes(
        [FromQuery] CustomsDetailedDeclarationTaxFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsDetailedDeclarationTaxes(filter));
    }

    /// <summary>
    ///     Meta data about CUSTOMS DETAILED DECLARATION TAX records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CustomsDetailedDeclarationTaxesMeta(
        [FromQuery] CustomsDetailedDeclarationTaxFindManyArgs filter
    )
    {
        return Ok(await _service.CustomsDetailedDeclarationTaxesMeta(filter));
    }

    /// <summary>
    ///     Get one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CustomsDetailedDeclarationTax>> CustomsDetailedDeclarationTax(
        [FromRoute] CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CustomsDetailedDeclarationTax(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one CUSTOMS DETAILED DECLARATION TAX
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCustomsDetailedDeclarationTax(
        [FromRoute] CustomsDetailedDeclarationTaxWhereUniqueInput uniqueId,
        [FromQuery] CustomsDetailedDeclarationTaxUpdateInput customsDetailedDeclarationTaxUpdateDto
    )
    {
        try
        {
            await _service.UpdateCustomsDetailedDeclarationTax(
                uniqueId,
                customsDetailedDeclarationTaxUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
