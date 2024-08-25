using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class ContainerOfTheDetailedDeclarationCustomsItemsControllerBase : ControllerBase
{
    protected readonly IContainerOfTheDetailedDeclarationCustomsItemsService _service;

    public ContainerOfTheDetailedDeclarationCustomsItemsControllerBase(
        IContainerOfTheDetailedDeclarationCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ContainerOfTheDetailedDeclarationCustoms>
    > CreateContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsCreateInput input
    )
    {
        var containerOfTheDetailedDeclarationCustoms =
            await _service.CreateContainerOfTheDetailedDeclarationCustoms(input);

        return CreatedAtAction(
            nameof(ContainerOfTheDetailedDeclarationCustoms),
            new { id = containerOfTheDetailedDeclarationCustoms.Id },
            containerOfTheDetailedDeclarationCustoms
        );
    }

    /// <summary>
    ///     Delete one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteContainerOfTheDetailedDeclarationCustoms(
        [FromRoute] ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteContainerOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ContainerOfTheDetailedDeclarationCustoms>>
    > ContainerOfTheDetailedDeclarationCustomsItems(
        [FromQuery] ContainerOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.ContainerOfTheDetailedDeclarationCustomsItems(filter));
    }

    /// <summary>
    ///     Meta data about CONTAINER OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ContainerOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery] ContainerOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.ContainerOfTheDetailedDeclarationCustomsItemsMeta(filter));
    }

    /// <summary>
    ///     Get one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ContainerOfTheDetailedDeclarationCustoms>
    > ContainerOfTheDetailedDeclarationCustoms(
        [FromRoute] ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ContainerOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateContainerOfTheDetailedDeclarationCustoms(
        [FromRoute] ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery]
        ContainerOfTheDetailedDeclarationCustomsUpdateInput containerOfTheDetailedDeclarationCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateContainerOfTheDetailedDeclarationCustoms(
                uniqueId,
                containerOfTheDetailedDeclarationCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
