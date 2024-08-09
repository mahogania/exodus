using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ModelSpecificationOfTheDetailedDeclarationCustomsItemsControllerBase
    : ControllerBase
{
    protected readonly IModelSpecificationOfTheDetailedDeclarationCustomsItemsService _service;

    public ModelSpecificationOfTheDetailedDeclarationCustomsItemsControllerBase(
        IModelSpecificationOfTheDetailedDeclarationCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ModelSpecificationOfTheDetailedDeclarationCustoms>
    > CreateModelSpecificationOfTheDetailedDeclarationCustoms(
        ModelSpecificationOfTheDetailedDeclarationCustomsCreateInput input
    )
    {
        var modelSpecificationOfTheDetailedDeclarationCustoms =
            await _service.CreateModelSpecificationOfTheDetailedDeclarationCustoms(input);

        return CreatedAtAction(
            nameof(ModelSpecificationOfTheDetailedDeclarationCustoms),
            new { id = modelSpecificationOfTheDetailedDeclarationCustoms.Id },
            modelSpecificationOfTheDetailedDeclarationCustoms
        );
    }

    /// <summary>
    /// Delete one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteModelSpecificationOfTheDetailedDeclarationCustoms(
        [FromRoute()] ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteModelSpecificationOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ModelSpecificationOfTheDetailedDeclarationCustoms>>
    > ModelSpecificationOfTheDetailedDeclarationCustomsItems(
        [FromQuery()] ModelSpecificationOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.ModelSpecificationOfTheDetailedDeclarationCustomsItems(filter));
    }

    /// <summary>
    /// Meta data about MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > ModelSpecificationOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery()] ModelSpecificationOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(
            await _service.ModelSpecificationOfTheDetailedDeclarationCustomsItemsMeta(filter)
        );
    }

    /// <summary>
    /// Get one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ModelSpecificationOfTheDetailedDeclarationCustoms>
    > ModelSpecificationOfTheDetailedDeclarationCustoms(
        [FromRoute()] ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ModelSpecificationOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateModelSpecificationOfTheDetailedDeclarationCustoms(
        [FromRoute()] ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery()]
            ModelSpecificationOfTheDetailedDeclarationCustomsUpdateInput modelSpecificationOfTheDetailedDeclarationCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateModelSpecificationOfTheDetailedDeclarationCustoms(
                uniqueId,
                modelSpecificationOfTheDetailedDeclarationCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
