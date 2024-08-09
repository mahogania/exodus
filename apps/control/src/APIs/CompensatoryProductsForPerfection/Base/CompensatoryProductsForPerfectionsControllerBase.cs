using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CompensatoryProductsForPerfectionsControllerBase : ControllerBase
{
    protected readonly ICompensatoryProductsForPerfectionsService _service;

    public CompensatoryProductsForPerfectionsControllerBase(
        ICompensatoryProductsForPerfectionsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CompensatoryProductsForPerfection>
    > CreateCompensatoryProductsForPerfection(CompensatoryProductsForPerfectionCreateInput input)
    {
        var compensatoryProductsForPerfection =
            await _service.CreateCompensatoryProductsForPerfection(input);

        return CreatedAtAction(
            nameof(CompensatoryProductsForPerfection),
            new { id = compensatoryProductsForPerfection.Id },
            compensatoryProductsForPerfection
        );
    }

    /// <summary>
    /// Delete one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCompensatoryProductsForPerfection(
        [FromRoute()] CompensatoryProductsForPerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCompensatoryProductsForPerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COMPENSATORY PRODUCTS FOR PERFECTIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<CompensatoryProductsForPerfection>>
    > CompensatoryProductsForPerfections(
        [FromQuery()] CompensatoryProductsForPerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.CompensatoryProductsForPerfections(filter));
    }

    /// <summary>
    /// Meta data about COMPENSATORY PRODUCTS FOR PERFECTION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CompensatoryProductsForPerfectionsMeta(
        [FromQuery()] CompensatoryProductsForPerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.CompensatoryProductsForPerfectionsMeta(filter));
    }

    /// <summary>
    /// Get one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CompensatoryProductsForPerfection>
    > CompensatoryProductsForPerfection(
        [FromRoute()] CompensatoryProductsForPerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CompensatoryProductsForPerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one COMPENSATORY PRODUCTS FOR PERFECTION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCompensatoryProductsForPerfection(
        [FromRoute()] CompensatoryProductsForPerfectionWhereUniqueInput uniqueId,
        [FromQuery()]
            CompensatoryProductsForPerfectionUpdateInput compensatoryProductsForPerfectionUpdateDto
    )
    {
        try
        {
            await _service.UpdateCompensatoryProductsForPerfection(
                uniqueId,
                compensatoryProductsForPerfectionUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
