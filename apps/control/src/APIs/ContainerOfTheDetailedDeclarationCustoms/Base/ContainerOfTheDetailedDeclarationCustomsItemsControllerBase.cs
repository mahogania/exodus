using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
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
    /// Create one Container Of The Detailed Declaration
    /// </summary>
    [HttpPost()]
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
    /// Delete one Container Of The Detailed Declaration
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteContainerOfTheDetailedDeclarationCustoms(
        [FromRoute()] ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
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
    /// Find many CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ContainerOfTheDetailedDeclarationCustoms>>
    > ContainerOfTheDetailedDeclarationCustomsItems(
        [FromQuery()] ContainerOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.ContainerOfTheDetailedDeclarationCustomsItems(filter));
    }

    /// <summary>
    /// Meta data about Container Of The Detailed Declaration records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ContainerOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery()] ContainerOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.ContainerOfTheDetailedDeclarationCustomsItemsMeta(filter));
    }

    /// <summary>
    /// Get one Container Of The Detailed Declaration
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ContainerOfTheDetailedDeclarationCustoms>
    > ContainerOfTheDetailedDeclarationCustoms(
        [FromRoute()] ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
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
    /// Update one Container Of The Detailed Declaration
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateContainerOfTheDetailedDeclarationCustoms(
        [FromRoute()] ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery()]
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

    /// <summary>
    /// Get a COMMON DETAILED DECLARATIONS record for CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}/commonDetailedDeclarations")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> GetCommonDetailedDeclarations(
        [FromRoute()] ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclarations(uniqueId);
        return Ok(commonDetailedDeclaration);
    }
}
