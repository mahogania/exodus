using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class SimplifiedCustomsClearanceOfPostalParcelsItemsControllerBase : ControllerBase
{
    protected readonly ISimplifiedCustomsClearanceOfPostalParcelsItemsService _service;

    public SimplifiedCustomsClearanceOfPostalParcelsItemsControllerBase(
        ISimplifiedCustomsClearanceOfPostalParcelsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<SimplifiedCustomsClearanceOfPostalParcels>
    > CreateSimplifiedCustomsClearanceOfPostalParcels(
        SimplifiedCustomsClearanceOfPostalParcelsCreateInput input
    )
    {
        var simplifiedCustomsClearanceOfPostalParcels =
            await _service.CreateSimplifiedCustomsClearanceOfPostalParcels(input);

        return CreatedAtAction(
            nameof(SimplifiedCustomsClearanceOfPostalParcels),
            new { id = simplifiedCustomsClearanceOfPostalParcels.Id },
            simplifiedCustomsClearanceOfPostalParcels
        );
    }

    /// <summary>
    ///     Delete one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteSimplifiedCustomsClearanceOfPostalParcels(
        [FromRoute] SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteSimplifiedCustomsClearanceOfPostalParcels(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELSItems
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<SimplifiedCustomsClearanceOfPostalParcels>>
    > SimplifiedCustomsClearanceOfPostalParcelsItems(
        [FromQuery] SimplifiedCustomsClearanceOfPostalParcelsFindManyArgs filter
    )
    {
        return Ok(await _service.SimplifiedCustomsClearanceOfPostalParcelsItems(filter));
    }

    /// <summary>
    ///     Meta data about SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> SimplifiedCustomsClearanceOfPostalParcelsItemsMeta(
        [FromQuery] SimplifiedCustomsClearanceOfPostalParcelsFindManyArgs filter
    )
    {
        return Ok(await _service.SimplifiedCustomsClearanceOfPostalParcelsItemsMeta(filter));
    }

    /// <summary>
    ///     Get one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<SimplifiedCustomsClearanceOfPostalParcels>
    > SimplifiedCustomsClearanceOfPostalParcels(
        [FromRoute] SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.SimplifiedCustomsClearanceOfPostalParcels(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one SIMPLIFIED CUSTOMS CLEARANCE OF POSTAL PARCELS
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateSimplifiedCustomsClearanceOfPostalParcels(
        [FromRoute] SimplifiedCustomsClearanceOfPostalParcelsWhereUniqueInput uniqueId,
        [FromQuery]
        SimplifiedCustomsClearanceOfPostalParcelsUpdateInput simplifiedCustomsClearanceOfPostalParcelsUpdateDto
    )
    {
        try
        {
            await _service.UpdateSimplifiedCustomsClearanceOfPostalParcels(
                uniqueId,
                simplifiedCustomsClearanceOfPostalParcelsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
